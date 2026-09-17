# 2026_Eblumbit

## To Migrations

### Install Entity Framework Core Tool
Installs the EF Core command-line tools globally on your machine to enable the dotnet ef command.

```
dotnet tool install --global dotnet-ef
```
- `tool install`: Tells .NET to download and install a specific utility.
- `--global`: Makes the command available everywhere in your system, not just the current folder.
- `dotnet-ef`: The name of the package containing the Entity Framework Core CLI tools.

### Generate migration
Compares your C# models with the current state and generates the code files (the blueprint) for the new tables.

```
dotnet ef migrations add UsersRoles
```
- `migrations`: Enters the migrations management context.
- `add`: The action to create a new migration snapshot.
- `UsersRole`s: The custom name of your migration. It should briefly describe the changes made to the models (e.g., creating user and role entities).

### Apply migration
Executes the pending migrations and applies the changes directly to the real database.

```
dotnet ef database update
```
- `database`: Enters the database operations context.
- `update`: The action that runs the Up method of any pending migration files to sync the database schema with your C# code.
