using DataLayer.IRepositories;
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

        public PoddRepository(MongoDBService mongoDbService)
        {
            _poddCollection = mongoDbService.GetCollection<Podd>("Podds");
        }

        // READ ALL
        public async Task<List<Podd>> GetAllAsync()
        {
            var filter = Builders<Podd>.Filter.Empty;
            var cursor = await _poddCollection.FindAsync(filter);
            return await cursor.ToListAsync();
        }

        // READ ONE
        public async Task<Podd?> GetByIdAsync(string id)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, id);
            var cursor = await _poddCollection.FindAsync(filter);
            return await cursor.FirstOrDefaultAsync();
        }

        // CREATE 
        public async Task AddAsync(Podd podd)
        {
            using var session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                await _poddCollection.InsertOneAsync(session, podd);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // UPDATE
        public async Task<bool> UpdateAsync(Podd podd)
        {
            using var session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Podd>.Filter.Eq(p => p.Id, podd.Id);
                var result = await _poddCollection.ReplaceOneAsync(session, filter, podd);

                await session.CommitTransactionAsync();

                return result.ModifiedCount > 0;
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // DELETE 
        public async Task<bool> DeleteAsync(string id)
        {
            using var session = await _poddCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Podd>.Filter.Eq(p => p.Id, id);
                var result = await _poddCollection.DeleteOneAsync(session, filter);

                await session.CommitTransactionAsync();

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