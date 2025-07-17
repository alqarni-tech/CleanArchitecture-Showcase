using CleanArchShowcase.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchShowcase.Application
{
    /// <summary>
    /// Application service for managing tasks.
    /// </summary>
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TaskDto>> GetAllAsync()
        {
            var tasks = await _repository.GetAllAsync();
            return tasks.Select(t => ToDto(t));
        }

        public async Task<TaskDto?> GetByIdAsync(int id)
        {
            var task = await _repository.GetByIdAsync(id);
            return task == null ? null : ToDto(task);
        }

        public async Task<TaskDto> AddAsync(TaskDto dto)
        {
            var task = new Task
            {
                Title = dto.Title,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted
            };
            var created = await _repository.AddAsync(task);
            return ToDto(created);
        }

        public async Task UpdateAsync(TaskDto dto)
        {
            var task = new Task
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description,
                IsCompleted = dto.IsCompleted
            };
            await _repository.UpdateAsync(task);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        private static TaskDto ToDto(Task t) => new TaskDto
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            IsCompleted = t.IsCompleted
        };
    }
} 