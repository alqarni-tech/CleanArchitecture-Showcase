# Developer Notes

- The in-memory repository is for demo/testing. Swap for a real DB in production.
- All services and repositories are registered in DI in `Program.cs`.
- Health checks and exception handling are enabled by default.
- To add new features, follow the Clean Architecture layering:
  1. Add entity/interface to Domain
  2. Add DTO/service to Application
  3. Implement repository in Infrastructure
  4. Add controller/endpoints in API
- Run tests with `dotnet test`. 