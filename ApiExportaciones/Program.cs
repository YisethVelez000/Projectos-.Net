using ApiExportacion;
using ApiExportacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<ExportacionContext>(p => p.UseInMemoryDatabase("TareasDB")); //Nombre de la base de datos
builder.Services .AddSqlServer<ExportacionContext>(builder.Configuration.GetConnectionString("cnExportaciones"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconexion",  async ([FromServices] ExportacionContext dbContext) =>
{
    try
    {
        dbContext.Database.EnsureCreated();
        return Results.Ok("Base de datos creada");
    }
    catch (System.Exception)
    {
        return Results.Ok("Error al crear la base de datos");

        throw;
    }
});

app.MapGet("/Exportaciones", async ([FromServices] ExportacionContext dbContext)=>{
    var Exportaciones = await dbContext.Exportaciones.ToListAsync();
    return Results.Ok(Exportaciones);
});

//Creamos el post 
app.MapPost("/Exportaciones", async ([FromServices] ExportacionContext dbContext, Exportacion exportacion)=>{
    dbContext.Exportaciones.Add(exportacion);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/Exportaciones/{exportacion.ProductoId}", exportacion);
});

//Creamos el put
app.MapPut("/Exportaciones/{id}", async ([FromServices] ExportacionContext dbContext, string id, Exportacion Exportacion) =>
{
    if (id != Exportacion.ProductoId.ToString())
    {
        return Results.BadRequest();
    }
    dbContext.Entry(Exportacion).State = EntityState.Modified;
    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Exportaciones.FindAsync(id) == null)
        {
            return Results.NotFound();
        }
        throw;
    }
    return Results.NoContent();
});

//Creamos el delete 
app.MapDelete("/Exportaciones/{id}", async ([FromServices] ExportacionContext dbContext, string id) =>
{
    var Exportacion = await dbContext.Exportaciones.FindAsync(id);
    if (Exportacion == null)
    {
        return Results.NotFound();
    }
    dbContext.Exportaciones.Remove(Exportacion);
    await dbContext.SaveChangesAsync();
    return Results.NoContent();
});

//Creamos el buscar por id 
app.MapGet("/Exportaciones/{id}", async ([FromServices] ExportacionContext dbContext, string id) =>
{
    var Exportacion = await dbContext.Exportaciones.FindAsync(id);
    if (Exportacion == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(Exportacion);
});

app.Run();
