# RopodApp API

A WhatsApp-like messaging API built with ASP.NET Core using Clean Architecture principles.

## Features

- **User Management**: Registration, authentication, profile management
- **Real-time Messaging**: Send/receive messages with SignalR
- **Chat Management**: Private chats, group chats, channels
- **File Sharing**: Image, video, audio, and document sharing
- **Stories**: Temporary status updates with 24-hour expiry
- **Message Reactions**: Emoji reactions on messages
- **Contact Management**: Add/remove contacts, blocking functionality
- **Real-time Notifications**: Push notifications for messages and activities

## Architecture

This project follows Clean Architecture principles with the following layers:

- **API Layer** (`RopodApp.API`): Controllers, Hubs, Middleware
- **Application Layer** (`RopodApp.Application`): Services, DTOs, Interfaces, Validators
- **Domain Layer** (`RopodApp.Domain`): Entities, Enums, Domain Interfaces
- **Infrastructure Layer** (`RopodApp.Infrastructure`): Data Access, External Services
- **Shared Layer** (`RopodApp.Shared`): Common Models, Exceptions, Helpers

## Technologies

- **.NET 8**: Core framework
- **ASP.NET Core Web API**: RESTful API
- **Entity Framework Core**: ORM for data access
- **SignalR**: Real-time communication
- **JWT**: Authentication and authorization
- **AutoMapper**: Object mapping
- **FluentValidation**: Input validation
- **BCrypt**: Password hashing
- **xUnit**: Unit and integration testing

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server (or SQL Server LocalDB)
- Visual Studio 2022 or VS Code

### Installation

1. Clone the repository
```bash
git clone <repository-url>
cd RopodApp
```

2. Restore dependencies
```bash
dotnet restore
```

3. Update the connection string in `appsettings.json`

4. Run database migrations
```bash
dotnet ef database update --project src/RopodApp.Infrastructure --startup-project src/RopodApp.API
```

5. Run the application
```bash
dotnet run --project src/RopodApp.API
```

## API Documentation

Once running, access the Swagger documentation at:
- `https://localhost:5001/swagger` (HTTPS)
- `http://localhost:5000/swagger` (HTTP)

## Testing

Run unit tests:
```bash
dotnet test tests/RopodApp.UnitTests
```

Run integration tests:
```bash
dotnet test tests/RopodApp.IntegrationTests
```

## Project Structure

```
RopodApp/
├── src/
│   ├── RopodApp.API/           # Web API layer
│   ├── RopodApp.Application/   # Application services and logic
│   ├── RopodApp.Domain/        # Domain entities and business rules
│   ├── RopodApp.Infrastructure/# Data access and external services
│   └── RopodApp.Shared/        # Shared utilities and models
├── tests/
│   ├── RopodApp.UnitTests/     # Unit tests
│   └── RopodApp.IntegrationTests/ # Integration tests
└── RopodApp.sln
```

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests for new features
5. Submit a pull request

## License

This project is licensed under the MIT License - see the LICENSE file for details.
