using ModelsLayer;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PoddRepository : IRepository<Podd>
    {
        private readonly IMongoCollection<Podd> _poddCollection;

        /// Konstruktorn tar emot MongoDBService och hämtar rätt samling.
        public PoddRepository(MongoDBService mongoDbService)
        {
            _poddCollection = mongoDbService.GetCollection<Podd>("Podds");
        }

        //  READ ALL (R i CRUD) Hämtar alla poddar från databasen.
        public async Task<List<Podd>> GetAllAsync()
        {
            // Tomt filter = matcha allt
            FilterDefinition<Podd> filter = Builders<Podd>.Filter.Empty;

            // Utför sökningen
            IAsyncCursor<Podd> cursor = await _poddCollection.FindAsync(filter);

            // Konverterar resultatet till en lista
            List<Podd> poddar = await cursor.ToListAsync();
            return poddar;
        }

        //  READ ONE (R i CRUD) Hämtar en podd baserat på ID.
        public async Task<Podd?> GetByIdAsync(string id)
        {
            FilterDefinition<Podd> filter = Builders<Podd>.Filter.Eq(p => p.Id, id);

            IAsyncCursor<Podd> cursor = await _poddCollection.FindAsync(filter);

            // Returnerar 1 matchande dokument eller null
            Podd podd = await cursor.FirstOrDefaultAsync();
            return podd;
        }

        //  CREATE (C i CRUD) Lägger till en ny podd i databasen med transaktion.
        public async Task AddAsync(Podd podd)
        {
            // Startar en databas-session för transaktionen
            IClientSessionHandle session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                // Själva INSERT-operationen
                await _poddCollection.InsertOneAsync(session, podd);

                // Slutför transaktionen
                await session.CommitTransactionAsync();
            }
            catch
            {
                // Vid fel – rulla tillbaka ändringar
                await session.AbortTransactionAsync();
                throw;
            }
        }

        //  UPDATE (U i CRUD) Uppdaterar ett existerande dokument baserat på Id. ReplaceOne = ersätt hela objektet med det nya.
        public async Task<bool> UpdateAsync(Podd podd)
        {
            IClientSessionHandle session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                // Filter som hittar rätt podd
                FilterDefinition<Podd> filter = Builders<Podd>.Filter.Eq(p => p.Id, podd.Id);

                // Byter ut hela dokumentet
                ReplaceOneResult result = await _poddCollection.ReplaceOneAsync(session, filter, podd);

                await session.CommitTransactionAsync();

                // Returnera true om något dokument faktiskt uppdaterades
                return result.ModifiedCount > 0;
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        //  DELETE (D i CRUD) Tar bort ett dokument baserat på ID med transaktion.
        public async Task<bool> DeleteAsync(string id)
        {
            IClientSessionHandle session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                // Filter för att hitta rätt dokument
                FilterDefinition<Podd> filter = Builders<Podd>.Filter.Eq(p => p.Id, id);

                // Tar bort ett dokument
                DeleteResult result = await _poddCollection.DeleteOneAsync(session, filter);

                await session.CommitTransactionAsync();

                // Returnera true om något dokument faktiskt togs bort
                return result.DeletedCount > 0;
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }
    }
}