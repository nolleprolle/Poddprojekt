using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<List<Category>> GetAllAsync()
        {
            return _categoryRepository.GetAllAsync();
        }

        public Task<Category?> GetByIdAsync(string id)
        {
            return _categoryRepository.GetByIdAsync(id);
        }

        public Task AddAsync(Category category)
        {
            return _categoryRepository.AddAsync(category);
        }

        public Task<bool> UpdateAsync(Category category)
        {
            return _categoryRepository.UpdateAsync(category);
        }

        public Task<bool> DeleteAsync(string id)
        {
            return _categoryRepository.DeleteAsync(id);
        }
    }
}