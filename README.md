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



###  Create database

<pre>dotnet ef database update</pre>



###  Create migration

<pre>dotnet ef migrations add InitialCreate</pre>



###  Apply migration

<pre>dotnet ef database update</pre>



###  Run application

<pre>dotnet clean</pre>
<pre>dotnet run</pre>



###  List of API endpoints

<p> POST    api/Auth/login </p>
<p> GET     api/Dashboard </p>
<p> GET     api/PlatformWell/GetPlatformWellActual </p>
<p> GET     api/PlatformWell/GetPlatformWellDummy </p>
<p> GET     api/PlatformWell/sqlTest </p>
