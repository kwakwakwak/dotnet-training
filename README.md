# Dotnet Training

## Description

This project follows the Microsoft's [Tutorial: Create a minimal API with ASP.NET Core](https://learn.microsoft.com/fr-fr/aspnet/core/tutorials/min-web-api?view=aspnetcore-9.0) and extrapolates from there.
The referenced tutorial provides instructions to build a simple REST API to manage TODO lists in C#.  

The goal is to improve the API to make it (almost) production ready! 

* Make it usable in real life
    * Add a PostgreSQL DB :white_check_mark:
    * Update the models to have several TODO lists
* Make it future-proof & maintainable
    * Improve the code architecture (decouple the code, following some hexagonal architecture principles)
    * Improve documentation
    * Add tests
    * Add Helm deployment to a simple K8s cluster

* Make it secure
    * Add error handling
    * Add logs
    * Use secrets management
    * Add authentication / authorization

## Database migrations

```Powershell
# To generate the first migration
dotnet ef migrations add InitialCreate

# To update the database
dotnet ef database update
```