using APiNumero1;
using APiNumero1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB")); //Nombre de la base de datos
builder.Services .AddSqlServer<TareasContext>("Data Source=LAPTOP-K0S7DIC0;Initial Catalog=TareasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion",  async ([FromServices] TareasContext dbContext) =>
{
    try
    {
        dbContext.Database.EnsureCreated();
        return Results.Ok("Base de datos en memoria " + dbContext.Database.IsInMemory());
    }
    catch (System.Exception)
    {
        return Results.Ok("Error al crear la base de datos");

        throw;
    }
});


app.Run();
