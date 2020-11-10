-- Various Dotnet Commands

dotnet new sln
dotnet new classlib -n <project>
dotnet new webapi -n API
dotnet add reference 

dotnet sln add (start typing proj name and hit tab)
dotnet sln list

dotnet run -p API/

dotnet ef migrations add InitialCreate -p Persistence/ -s API/
use dotnet build to troubleshoot further

dotnet ef database (drop and update)

Force .net core version

--- dotnet new globaljson --sdk-version 3.0.103 --force

sudo apt-get install sqlite3
