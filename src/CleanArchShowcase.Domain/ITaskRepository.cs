using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchShowcase.Domain
{
    /// <summary>
    /// Abstraction for task repository.
    /// </summary>
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetAllAsync();
        Task<Task?> GetByIdAsync(int id);
        Task<Task> AddAsync(Task task);
        Task UpdateAsync(Task task);
        Task DeleteAsync(int id);
    }
} 