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
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IMongoCollection<Category> _categoryCollection;

        /// <summary>
        /// Konstruktorn tar emot MongoDBService och hämtar rätt collection.
        /// </summary>
        public CategoryRepository(MongoDBService mongoService)
        {
            _categoryCollection = mongoService.GetCollection<Category>("Categories");
        }

        // READ ALL (R i CRUD) – hämtar alla kategorier.
        public async Task<List<Category>> GetAllAsync()
        {
            FilterDefinition<Category> filter = Builders<Category>.Filter.Empty;
            IAsyncCursor<Category> cursor = await _categoryCollection.FindAsync(filter);
            List<Category> categories = await cursor.ToListAsync();
            return categories;
        }

        // READ ONE (R i CRUD) – hämtar en kategori baserat på Id.
        public async Task<Category?> GetByIdAsync(string id)
        {
            FilterDefinition<Category> filter = Builders<Category>.Filter.Eq(c => c.Id, id);
            IAsyncCursor<Category> cursor = await _categoryCollection.FindAsync(filter);
            Category category = await cursor.FirstOrDefaultAsync();
            return category;
        }

        // CREATE (C i CRUD) – lägger till en ny kategori med transaktion.
        public async Task AddAsync(Category category)
        {
            IClientSessionHandle session = await _categoryCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                await _categoryCollection.InsertOneAsync(session, category);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // UPDATE (U i CRUD) – uppdaterar en kategori baserat på Id.
        public async Task<bool> UpdateAsync(Category category)
        {
            IClientSessionHandle session = await _categoryCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                FilterDefinition<Category> filter = Builders<Category>.Filter.Eq(c => c.Id, category.Id);
                ReplaceOneResult result = await _categoryCollection.ReplaceOneAsync(session, filter, category);

                await session.CommitTransactionAsync();

                // true om något dokument faktiskt uppdaterades
                return result.ModifiedCount > 0;
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // DELETE (D i CRUD) – tar bort en kategori baserat på Id.
        public async Task<bool> DeleteAsync(string id)
        {
            IClientSessionHandle session = await _categoryCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                FilterDefinition<Category> filter = Builders<Category>.Filter.Eq(c => c.Id, id);
                DeleteResult result = await _categoryCollection.DeleteOneAsync(session, filter);

                await session.CommitTransactionAsync();

                // true om något dokument faktiskt togs bort
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