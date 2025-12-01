using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface IEpisodeService
    {
        Task<List<Episode>> GetAllAsync();
        Task<Episode?> GetByIdAsync(string id);
        Task AddAsync(Episode episode);
        Task<bool> UpdateAsync(Episode episode);
        Task<bool> DeleteAsync(string id);
        Task<List<Episode>> GetByPoddIdAsync(string poddId);
    }
}