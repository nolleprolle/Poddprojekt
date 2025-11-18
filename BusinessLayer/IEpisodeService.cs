using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IEpisodeService
    {
        Task<List<Episode>> GetAllAsync();
        Task<Episode?> GetByIdAsync(string id);
        Task AddAsync(Episode episode);
        Task<bool> UpdateAsync(Episode episode);
        Task<bool> DeleteAsync(string id);

        // Extra hjälpmetod: hämta alla episoder för en viss podd
        Task<List<Episode>> GetByPoddIdAsync(string poddId);
    }
}