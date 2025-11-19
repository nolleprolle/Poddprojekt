using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(string id);
        Task AddAsync(Category category);
        Task<bool> UpdateAsync(Category category);
        Task<bool> DeleteAsync(string id);
    }
}