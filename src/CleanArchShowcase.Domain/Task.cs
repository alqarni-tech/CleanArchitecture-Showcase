namespace CleanArchShowcase.Domain
{
    /// <summary>
    /// Represents a task in the system.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Gets or sets the unique identifier for the task.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets whether the task is completed.
        /// </summary>
        public bool IsCompleted { get; set; }
    }
} 