# Contoso University sample app

Contoso University demonstrates how to use Entity Framework Core in an
ASP.NET Core 2.0 MVC web application on Mysql/Aws Aurora server.\n
It's support Aws Aurora Writer/Reader Endpoint.

## Reader Endpoint
We  implement design-time factory, so you can configure the DbContext using the Mysql/Aws Aurora Reader Endpoint at design time.
You can set two connonection string on the appsettings.json file\n
-> Writer\n
-> Reader\n

### Option 1 : Create design-time Factory
Please see the how to use the reader endpoint from\n 
- ApiFactoryController.cs
How to Create design-time Factory from\n
- SchoolContextFactory.cs

### Option 2 : Create two Context
Please see the how to use the reader endpoint from\n
- ApiTwoContextController.cs 
How to create two Contexts from\n 
- SchoolContext.cs
- SchoolReaderContext.cs
- Startup.cs

## Change
I have changed the Department -> Budget field from Type "Money" to "decimal\n
Because the Mysql Ef doesn't support the "Money" type

## Base on

The project is base on the Microsoft Contoso University .net code 2.0 example\n
Download the [completed project](https://github.com/aspnet/Docs/tree/master/aspnetcore/data/ef-mvc/intro/samples/cu-final) from GitHub

## Download it

Download the [completed project](https://github.com/szmulder/ContosoUniversity.Mysql) from GitHub by downloading in your local file system.  After downloading the project, create the database by entering `dotnet ef database update` at a command-line prompt. As an alternative you can use **Package Manager Console** -- for more information, see [Command-line interface (CLI) vs. Package Manager Console (PMC)](https://docs.microsoft.com/aspnet/core/data/ef-mvc/migrations#command-line-interface-cli-vs-package-manager-console-pmc).
