lo primero es en la carpeta examen correr el comando dotnet build o correr los siguientes commandos

1. dotnet add package Npgsql
2. dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
3. dotnet add package EFCore.NamingConventions
4. dotnet add package Microsoft.EntityFrameworkCore.Design
5. dotnet tool install --global dotnet-ef

despues ingresar al archivo appsettings.jason y modificar DefaultConnection con los datos de tu propia base de datos

despues de esto se correra el commando dotnet ef database update
Esto generar la base de datos

despues correr el comando dotnet run para iniciar el api

seguidamente ingresar en la carpeta Client y despues a la carpeta ExamenApi y correr el comando npm install

despues correr el comando ng serve

