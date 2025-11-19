using DataLayer.IRepositories;
using ModelsLayer;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IMongoCollection<Category> _categoryCollection;

        public CategoryRepository(MongoDBService mongoService)
        {
            _categoryCollection = mongoService.GetCollection<Category>("Categories");
        }

        // READ ALL
        public async Task<List<Category>> GetAllAsync()
        {
            var filter = Builders<Category>.Filter.Empty;
            var cursor = await _categoryCollection.FindAsync(filter);
            return await cursor.ToListAsync();
        }

        // READ ONE
        public async Task<Category?> GetByIdAsync(string id)
        {
            var filter = Builders<Category>.Filter.Eq(c => c.Id, id);
            var cursor = await _categoryCollection.FindAsync(filter);
            return await cursor.FirstOrDefaultAsync();
        }

        // CREATE
        public async Task AddAsync(Category category)
        {
            using var session = await _categoryCollection.Database.Client.StartSessionAsync();

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

        // UPDATE
        public async Task<bool> UpdateAsync(Category category)
        {
            using var session = await _categoryCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Category>.Filter.Eq(c => c.Id, category.Id);
                var result = await _categoryCollection.ReplaceOneAsync(session, filter, category);

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
            using var session = await _categoryCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Category>.Filter.Eq(c => c.Id, id);
                var result = await _categoryCollection.DeleteOneAsync(session, filter);

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