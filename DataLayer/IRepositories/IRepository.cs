using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepositories
{
    /// Generiskt repository-interface för grundläggande CRUD-operationer.
    /// Används av alla repositories (Podd, Episode, Category).
    public interface IRepository<T> where T : class
    {
        // CREATE
        Task AddAsync(T item);

        // READ ALL
        Task<List<T>> GetAllAsync();

        // READ ONE BY ID
        Task<T?> GetByIdAsync(string id);

        // UPDATE
        Task<bool> UpdateAsync(T item);

        // DELETE BY ID
        Task<bool> DeleteAsync(string id);
    }
}