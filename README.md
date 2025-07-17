# CleanArchitecture-Showcase

## Overview
A production-ready, educational .NET 9 solution demonstrating Clean Architecture, SOLID principles, and best practices. Includes a sample Task domain with full CRUD, in-memory repository, and automated tests.

## Features
- Clean Architecture layering (Domain, Application, Infrastructure, API)
- SOLID principles
- In-memory repository for demo/testing
- RESTful API with Swagger/OpenAPI
- Health checks and exception handling
- Dockerfile for containerization
- GitHub Actions CI/CD pipeline
- xUnit tests with Moq

## Project Structure
```
src/
  CleanArchShowcase.Domain/         # Domain entities and interfaces
  CleanArchShowcase.Application/    # Application services and DTOs
  CleanArchShowcase.Infrastructure/ # Repository implementations
  CleanArchShowcase.API/            # ASP.NET Core Web API

tests/
  CleanArchShowcase.Tests/          # Unit tests
```

## Setup Instructions
```sh
cd SaaS-Starter-Solutions/CleanArchitecture-Showcase
# Build
 dotnet build CleanArchitecture-Showcase.sln
# Run API
 dotnet run --project src/CleanArchShowcase.API/CleanArchShowcase.API.csproj
```

## API Documentation
Swagger UI: `/swagger` (in development mode)

## Health Checks
- `/health` returns 200 OK if the service is healthy.

## Docker
```sh
docker build -t cleanarchshowcase-api -f src/CleanArchShowcase.API/Dockerfile .
docker run -p 5000:80 cleanarchshowcase-api
```

## CI/CD
See `ci/build.yml` for GitHub Actions pipeline.

## Documentation
- [Architecture](docs/architecture.md)
- [Developer Notes](docs/developer-notes.md) 