using Microsoft.VisualBasic;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataLayer
{
    public class RssPoddClient
    {
        private readonly HttpClient aHttpClient;

        public RssPoddClient(HttpClient aHttpClient)
        {
            this.aHttpClient = aHttpClient;
        }
        public async Task<List<Episode>> GetRssEpisodeAsync(string rssLink)
        {
            using (var rssStream = await this.aHttpClient.GetStreamAsync(rssLink))
            using (var ourXmlReader = XmlReader.Create(rssStream))
            {
                SyndicationFeed dataStream = SyndicationFeed.Load(ourXmlReader);

                List<Episode> poddsList = new List<Episode>();

                foreach (SyndicationItem item in dataStream.Items)
                {
                    var aEpisode = new Episode
                    {
                        Title = item.Title?.Text,
                        Description = item.Summary?.Text,
                        AirDate = item.PublishDate.DateTime,
                        Link = item.Links.FirstOrDefault()?.Uri.ToString()
                    };

                    poddsList.Add(aEpisode);
                }

                return poddsList;
            }
        }
    }
}