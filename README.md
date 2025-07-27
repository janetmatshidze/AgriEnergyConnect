# AgriEnergyConnect
A comprehensive web platform that connects farmers with energy providers, 
streamlining agricultural product management and administrative oversight 
through secure user authentication and role-based access control.

# Overview
AgriEnergyConnect empowers farmers to efficiently manage their agricultural products while providing administrators with powerful tools for user and data management. 
The platform ensures data security through role-based permissions and provides intuitive interfaces for both user types.

# Key Features
## Farmer Portal
#### Secure Authentication: 
- Account registration and login system.
#### Product Management:
- Create products with name, category, and production date.

- Full CRUD operations (Create, Read, Update, Delete).

- Real-time product tracking and updates.
#### Access Control: 
- Protected from administrative functions with clear access denial feedback.
## Administrator Dashboard
#### User Management:
- Create and manage farmer profiles.

- Comprehensive farmer data (contact info, addresses, credentials).
#### Data Oversight:
- View all farmers and their products.

- Advanced filtering by category and production date.

- Complete system administration access.
#### Employee Management: 
- Full administrative controls (farmer-restricted).

## Technical Architecture
### Technology Stack
#### Framework: 
- ASP.NET Core 8 MVC
#### Database: 
- Entity Framework Core with SQL Server.
#### Authentication: 
- ASP.NET Identity with role-based authorization.
#### Frontend:
- Bootstrap 5 with Razor Pages.
#### Data Management: 
- EF Core migrations for schema management.
### Project Structure
- AgriEnergyConnect/
- Controllers/ – MVC controllers (HomeController, ProductsController, EmployeeController).
- Models/ – Entity models and ViewModels.
- Views/ – Razor views for UI.
- wwwroot/ – Static files (CSS, JS, images, fonts)
- Services/AgriEnergyConnectDBContext.cs – EF Core database context.
- Migrations/ – EF Core migrations for database schema.
- Properties/launchSettings.json – Environment and launch configuration.
### Getting Started
#### Prerequisites
- NET 8 SDK
- SQL Server (LocalDB, Express, or full version).
- Visual Studio 2022 or VS Code with C# extension.
### Installation & Setup
#### Clone the repository
- git clone https://github.com/janetmatshidze/AgriEnergyConnect.git
- cd AgriEnergyConnect
- dotnet restore
- dotnet ef database update
- dotnet run
### Configure Database Connection
- Update appsettings.json with the SQL Server connection string:
- "ConnectionStrings": "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgriEnergyConnect;Trusted_Connection=true;"
### License
- This project is licensed under the MIT License - see the LICENSE file for details.

  
