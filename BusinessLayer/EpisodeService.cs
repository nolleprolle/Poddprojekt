using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IRepository<Episode> _episodeRepository;

        public EpisodeService(IRepository<Episode> episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }

        public Task<List<Episode>> GetAllAsync()
        {
            return _episodeRepository.GetAllAsync();
        }

        public Task<Episode?> GetByIdAsync(string id)
        {
            return _episodeRepository.GetByIdAsync(id);
        }

        public Task AddAsync(Episode episode)
        {
            return _episodeRepository.AddAsync(episode);
        }

        public Task<bool> UpdateAsync(Episode episode)
        {
            return _episodeRepository.UpdateAsync(episode);
        }

        public Task<bool> DeleteAsync(string id)
        {
            return _episodeRepository.DeleteAsync(id);
        }

        /// <summary>
        /// Exempel på domänlogik i service-lagret:
        /// Filtrera fram alla avsnitt som tillhör en viss podd.
        /// (Enkel variant: hämta alla och filtrera i minnet.)
        /// </summary>
        public async Task<List<Episode>> GetByPoddIdAsync(string poddId)
        {
            List<Episode> allEpisodes = await _episodeRepository.GetAllAsync();
            List<Episode> filtered = allEpisodes
                .Where(e => e.Id == poddId)
                .ToList();
            return filtered;
        }
    }
}