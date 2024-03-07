using ApiNumero2;
using ApiNumero2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB")); //Nombre de la base de datos
builder.Services .AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
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
