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
        private HttpClient aHttpClient;

        public RssPoddClient()
        {
            this.aHttpClient = aHttpClient;
        }
        public async Task<List<Episode>> GetRssEpisodeAsync(string rssLink)
        {
            using (Stream rssStream = await this.aHttpClient.GetStreamAsync(rssLink))
            using (XmlReader ourXmlReader = XmlReader.Create(rssStream))
            {
                SyndicationFeed dataStream = SyndicationFeed.Load(ourXmlReader);

                List<Episode> poddsList = new List<Episode>();

                foreach (SyndicationItem item in dataStream.Items)
                {


                    Episode aEpisode = new Episode();
                    aEpisode.Id = item.Id.ToString();
                    aEpisode.Title = item.Title.Text;
                    aEpisode.Description = item.Summary.Text;
                    aEpisode.AirDate = item.PublishDate.DateTime;
                    aEpisode.Link = item.Links.First().Uri.ToString();

                    poddsList.Add(aEpisode);


                }
                return poddsList;

            }

        }

    }
}