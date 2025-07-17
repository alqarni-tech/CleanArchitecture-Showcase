using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchShowcase.Application
{
    /// <summary>
    /// Abstraction for task application service.
    /// </summary>
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetAllAsync();
        Task<TaskDto?> GetByIdAsync(int id);
        Task<TaskDto> AddAsync(TaskDto task);
        Task UpdateAsync(TaskDto task);
        Task DeleteAsync(int id);
    }
} 