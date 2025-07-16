# API CRUD Operations

A RESTful API built with ASP.NET Core that provides CRUD (Create, Read, Update, Delete) operations for managing employee data.

## Features

- Create new employee records
- Retrieve employee details
- Update existing employee information
- Delete employee records
- Built with ASP.NET Core
- Entity Framework Core for data access
- SQL Server database

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or full version)

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/AbdelrhamanWael/API_CRUD.git
   cd API_CRUD
   ```

2. **Update the database connection string**
   - Open `appsettings.json`
   - Update the `DefaultConnection` string to point to your SQL Server instance

3. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```
   The API will be available at `https://localhost:5001` or `http://localhost:5000`

## API Endpoints

### Employees

- `GET /api/employees` - Get all employees
- `GET /api/employees/{id}` - Get employee by ID
- `POST /api/employees` - Create a new employee
- `PUT /api/employees/{id}` - Update an existing employee
- `DELETE /api/employees/{id}` - Delete an employee

## Example Requests

### Create Employee
```http
POST /api/employees
Content-Type: application/json

{
  "name": "John Doe",
  "email": "john.doe@example.com",
  "department": "Engineering"
}
```

### Get All Employees
```http
GET /api/employees
```

### Get Employee by ID
```http
GET /api/employees/1
```

## Project Structure

- `Controllers/` - API controllers
- `Data/` - Data models and database context
- `Models/` - View models and DTOs
- `Migrations/` - Entity Framework Core migrations

## Technologies Used

- ASP.NET Core 7.0
- Entity Framework Core 7.0
- SQL Server
- Swagger/OpenAPI (if implemented)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.