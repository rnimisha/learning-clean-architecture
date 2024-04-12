## Folder Creation

1. Creating solution

   - dotnet new sln

2. Creating projects

   - dotnet new webapi -o Api
   - dotnet new classlib -o Domain
   - dotnet new classlib -o Application
   - dotnet new classlib -o Infrastructure

3. Add gitignore

   - dotnet new gitignore

4. Add projects to solution
   - dotnet sln add Application/Application.csproj
   - dotnet sln add Infrastructure/Infrastructure.csproj
   - dotnet sln add Domain/Domain.csproj
   - dotnet sln add Api/Api.csproj
