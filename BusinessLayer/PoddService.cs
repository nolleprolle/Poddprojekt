using BusinessLayer.IServices;
using DataLayer.IRepositories;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PoddService : IPoddService
    {
        private readonly IRepository<Podd> _poddRepository;

        /// Konstruktorn tar emot poddRepository som hanterar Podd-objekt
        public PoddService(IRepository<Podd> poddRepository)
        {
            _poddRepository = poddRepository;
        }

        public Task<List<Podd>> GetAllAsync()
        {
            return _poddRepository.GetAllAsync();
        }

        public Task<Podd?> GetByIdAsync(string id)
        {
            return _poddRepository.GetByIdAsync(id);
        }

        public Task AddAsync(Podd podd)
        {
            return _poddRepository.AddAsync(podd);
        }

        public Task<bool> UpdateAsync(Podd podd)
        {
            return _poddRepository.UpdateAsync(podd);
        }

        public Task<bool> DeleteAsync(string id)
        {
            return _poddRepository.DeleteAsync(id);
        }
    }
}