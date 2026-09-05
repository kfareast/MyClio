# LawOfficeManagement
A desktop application for managing clients, cases and documents for a small law office.

This project was developed as a learning and portfolio project using C#, Windows Forms, Entity Framework Core, and SQL Server LocalDB.

## Features

- **Client Management**
  - Add clients
  - Edit client information
  - Delete clients
  - Search clients

- **Case Management**
  - Create and manage cases
  - Associate cases with clients
  - Track case status

- **Document Management**
  - Manage documents associated with cases
  - Store document file paths
  - Open documents from the application
 
 ## Technologies

- C#
- .NET
- Windows Forms
- Entity Framework Core
- SQL Server LocalDB

## Database

The application uses SQL Server LocalDB.

The configured database is:

```text
Server:   (localdb)\MSSQLLocalDB
Database: LawOfficeDb
```

The database schema is managed using Entity Framework Core Migrations.

## Getting Started

### Requirements

- Visual Studio 2022
- .NET 8 SDK
- SQL Server Express LocalDB

### Run

1. Clone the repository.
2. Open the `.sln` file in Visual Studio.
3. Build and run the project.

The database will be created automatically on the first run.

## Note

This project was created while learning C#, Windows Forms, Entity Framework Core, and relational database development.

The main goal was to practice building a desktop CRUD application, working with database relationships, and using Entity Framework Core migrations.
