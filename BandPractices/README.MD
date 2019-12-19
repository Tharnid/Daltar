dotnet new classlib -n 
dotnet new webapi -n
dotnet sln add 
cd into project before adding reference..duh
dotnet sln list

dotnet add reference

dotnet run -p API/
dotnet tool install --global dotnet-ef

dotnet ef migrations add IntiMigration
dotnet ef migrations add IntiMigration -p Persistence/ -s API

# run this inside startup project
dotnet watch run

## React tools

npx create-react-app client-app --use-npm --typescript