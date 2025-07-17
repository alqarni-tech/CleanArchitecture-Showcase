# Architecture

This project follows Clean Architecture principles:

- **Domain Layer**: Contains core entities and repository interfaces (no dependencies on other layers).
- **Application Layer**: Contains DTOs, service interfaces, and business logic. Depends only on Domain.
- **Infrastructure Layer**: Implements repositories and data access. Depends on Application and Domain.
- **API Layer**: ASP.NET Core Web API. Depends on Application and Infrastructure.

## Dependency Flow

- API → Application → Domain
- Infrastructure → Application, Domain

## Example: Task Domain
- `Task` entity and `ITaskRepository` in Domain
- `TaskDto`, `ITaskService`, and `TaskService` in Application
- `InMemoryTaskRepository` in Infrastructure
- `TaskController` in API

## DI and Testing
- All dependencies are injected via constructor
- In-memory repository is used for demo/testing
- xUnit and Moq for unit tests 