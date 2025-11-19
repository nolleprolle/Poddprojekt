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

        // Standardkonstruktor – skapar själv HttpClient och RssPoddClient
        public RssClientService()
        {
            var httpClient = new HttpClient();
            _rssPoddClient = new RssPoddClient(httpClient);
        }

        // Extra konstruktor om man vill testa / mocka
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