

```# bash terminal
dotnet new sln -n Discoteque
dotnet new classlib -o Discoteque.Business
dotnet new webapi -o Discoteque.API
dotnet new classlib -o Discoteque.Data
dotnet new classlib -o Discoteque.Business
dotnet sln add Discoteque.API/
dotnet sln add Discoteque.Business/
dotnet sln add Discoteque.Data/
dotnet build

dotnet add package Microsoft.EntityFrameworkCore.InMemory
```