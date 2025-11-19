using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface IRssClientService
    {
        Task<List<Episode>> GetEpisodesFromRssAsync(string rssUrl);
    }
}