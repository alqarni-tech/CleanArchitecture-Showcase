using CleanArchShowcase.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchShowcase.Infrastructure
{
    /// <summary>
    /// In-memory implementation of ITaskRepository for demo/testing.
    /// </summary>
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks = new();
        private int _nextId = 1;

        public Task<IEnumerable<Task>> GetAllAsync()
        {
            return System.Threading.Tasks.Task.FromResult(_tasks.AsEnumerable());
        }

        public Task<Task?> GetByIdAsync(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            return System.Threading.Tasks.Task.FromResult(task);
        }

        public Task<Task> AddAsync(Task task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
            return System.Threading.Tasks.Task.FromResult(task);
        }

        public Task UpdateAsync(Task task)
        {
            var existing = _tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
                existing.IsCompleted = task.IsCompleted;
            }
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                _tasks.Remove(task);
            return System.Threading.Tasks.Task.CompletedTask;
        }
    }
} 