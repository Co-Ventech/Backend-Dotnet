# MyAppBackend

This is a boilerplate .NET Core Web API project using Entity Framework Core (in-memory for demo), SignalR, and Swagger/OpenAPI.

## Tech Stack

- Backend: C# with .NET Core (Web API)
- ORM: Entity Framework Core
- Real-time: SignalR
- API Docs: Swagger
- Database: In-memory (for local testing; can switch to SQL Server/Azure SQL)

## Prerequisites

- .NET SDK 10.0 (download from https://dotnet.microsoft.com/download)

## Setup and Run

1. Clone the repo: `git clone https://github.com/Co-Ventech/Backend-Dotnet.git`
2. Navigate: `cd BackendBoilerplate`
3. Restore packages: `dotnet restore`
4. Build: `dotnet build`
5. Run: `dotnet run`
6. Access Swagger: Open browser to `https://localhost:5001/swagger` (or the port shown in console)

## Project Structure

- `Controllers/`: API endpoints
- `Models/`: Domain models
- `Data/`: EF Core DbContext
- `Services/`: SignalR hubs and business logic
- `Program.cs`: Main configuration

## Future Enhancements

- Switch to Azure SQL and Storage for production.
- Add authentication (e.g., JWT).

## License

MIT License (or choose your own).
