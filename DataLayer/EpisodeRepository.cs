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
    public class EpisodeRepository : IRepository<Episode>
    {
        private readonly IMongoCollection<Episode> _episodeCollection;

        public EpisodeRepository(MongoDBService mongoService)
        {
            _episodeCollection = mongoService.GetCollection<Episode>("Episodes");
        }

        // READ ALL
        public async Task<List<Episode>> GetAllAsync()
        {
            var filter = Builders<Episode>.Filter.Empty;
            var cursor = await _episodeCollection.FindAsync(filter);
            return await cursor.ToListAsync();
        }

        // READ ONE
        public async Task<Episode?> GetByIdAsync(string id)
        {
            var filter = Builders<Episode>.Filter.Eq(e => e.Id, id);
            var cursor = await _episodeCollection.FindAsync(filter);
            return await cursor.FirstOrDefaultAsync();
        }

        // CREATE
        public async Task AddAsync(Episode episode)
        {
            using var session = await _episodeCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                await _episodeCollection.InsertOneAsync(session, episode);

                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        // UPDATE 
        public async Task<bool> UpdateAsync(Episode episode)
        {
            using var session = await _episodeCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Episode>.Filter.Eq(e => e.Id, episode.Id);
                var result = await _episodeCollection.ReplaceOneAsync(session, filter, episode);

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
            using var session = await _episodeCollection.Database.Client.StartSessionAsync();

            try
            {
                session.StartTransaction();

                var filter = Builders<Episode>.Filter.Eq(e => e.Id, id);
                var result = await _episodeCollection.DeleteOneAsync(session, filter);

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