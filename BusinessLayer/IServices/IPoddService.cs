using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface IPoddService
    {
        Task<List<Podd>> GetAllAsync();
        Task<Podd?> GetByIdAsync(string id);
        Task<bool> AddAsync(Podd podd);
        Task<bool> UpdateAsync(Podd podd);
        Task<bool> DeleteAsync(string id);
    }
}