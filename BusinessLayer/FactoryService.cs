using System.Net.Http;
using BusinessLayer.IServices;
using DataLayer;
using DataLayer.IRepositories;
using ModelsLayer;

namespace BusinessLayer
{
    public static class ServiceFactory
    {
        private static readonly MongoDBService _mongoService = new MongoDBService();

        // RSS-tjänst (läser in avsnitt från internet, inte DB)
        public static IRssClientService CreateRssService()
        {
            var http = new HttpClient();
            var rssClient = new RssPoddClient(http);
            return new RssClientService(rssClient);
        }

        public static ICategoryService CreateCategoryService()
        {
            IRepository<Category> categoryRepo = new CategoryRepository(_mongoService);
            return new CategoryService(categoryRepo);
        }

        public static IEpisodeService CreateEpisodeService()
        {
            IRepository<Episode> episodeRepo = new EpisodeRepository(_mongoService);
            return new EpisodeService(episodeRepo);
        }

        public static IPoddService CreatePoddService()
        {
            IRepository<Podd> poddRepo = new PoddRepository(_mongoService);
            return new PoddService(poddRepo);
        }
    }
}