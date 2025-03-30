# Dotnet Training

## Description

This project follows the Microsoft's tutorials and extrapolate from there:
    - [Tutorial: Create a minimal API with ASP.NET Core](https://learn.microsoft.com/fr-fr/aspnet/core/tutorials/min-web-api?view=aspnetcore-9.0)
    - [Tutorial: Create a controller-based web API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0)
The referenced tutorials provide instructions to build a simple REST API to manage TODO lists in C#.  

The goal is to improve the API to make it (almost) production ready! 

* Make it usable in real life
    * Add a PostgreSQL DB :white_check_mark:
    * Update the models to have several TODO lists
* Make it future-proof & maintainable
    * Improve the code architecture (decouple the code, following some hexagonal architecture principles)
    * Improve documentation
    * Add tests
    * Add Helm deployment to a simple K8s cluster

* Make it more secure
    * Add error handling
    * Add logs
    * Use secrets management
    * Add authentication / authorization

## Formatting and linting

```Powershell
# To format the code from the rules defined in .csharpierrc.yaml
dotnet-csharpier .

# To check the code formatting
dotnet csharpier --check .
```

## Database migrations

```Powershell
# To generate the first migration
dotnet ef migrations add InitialCreate

# To generate a new migration after updating the models
dotnet ef migrations add <MigrationName>

# To update the database
dotnet ef database update
```