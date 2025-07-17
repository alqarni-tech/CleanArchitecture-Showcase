namespace CleanArchShowcase.Application
{
    /// <summary>
    /// Data Transfer Object for Task.
    /// </summary>
    public class TaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
} 