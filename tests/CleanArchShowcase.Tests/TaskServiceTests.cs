using CleanArchShowcase.Application;
using CleanArchShowcase.Domain;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchShowcase.Tests
{
    public class TaskServiceTests
    {
        [Fact]
        public async Task GetAllAsync_ReturnsAllTasks()
        {
            // Arrange
            var mockRepo = new Mock<ITaskRepository>();
            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Task> {
                new Task { Id = 1, Title = "Test 1" },
                new Task { Id = 2, Title = "Test 2" }
            });
            var service = new TaskService(mockRepo.Object);

            // Act
            var result = await service.GetAllAsync();

            // Assert
            Assert.Collection(result,
                t => Assert.Equal("Test 1", t.Title),
                t => Assert.Equal("Test 2", t.Title));
        }
    }
} 