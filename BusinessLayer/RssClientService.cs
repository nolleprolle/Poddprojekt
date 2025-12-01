using BusinessLayer.IServices;
using DataLayer;
using ModelsLayer;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RssClientService : IRssClientService
    {
        private readonly RssPoddClient _rssPoddClient;

        public RssClientService()
        {
            var httpClient = new HttpClient();
            _rssPoddClient = new RssPoddClient(httpClient);
        }

        public RssClientService(RssPoddClient rssPoddClient)
        {
            _rssPoddClient = rssPoddClient;
        }

        public async Task<List<Episode>> GetEpisodesFromRssAsync(string rssUrl)
        {
            return await _rssPoddClient.GetRssEpisodeAsync(rssUrl);
        }
    }
}