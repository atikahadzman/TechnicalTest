# TechnicalTest 

.NET Core Web API application to sync Platform and Well data from REST API into SQL Server LocalDB using Entity Framework Core Code First.

## Database

Database name: TechnicalTestDb


## Setup

### Configure database connection

Update `appsettings.json`

```json
{
  "ConnectionStrings": {
    "DefaultConnection":
    "Server=(localdb)\\MSSQLLocalDB;Database=TechnicalTestDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```


###  Create database
```bash
dotnet ef database update
```


###  Create migration

```bash
dotnet ef migrations add InitialCreate
```


###  Apply migration
```bash
dotnet ef database update
```


###  Run application
```bash
dotnet clean
```
```bash
dotnet run
```


###  List of API endpoints
``` POST    api/Auth/login ```
<br/>
``` GET     api/Dashboard ```
<br/>
``` GET     api/PlatformWell/GetPlatformWellActual ```
<br/>
``` GET     api/PlatformWell/GetPlatformWellDummy ```
<br/>
``` GET     api/PlatformWell/sqlTest ```
