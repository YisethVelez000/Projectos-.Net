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


//Creamos un endpoint para obtener todas las categorias
app.MapGet("/categorias", async ([FromServices] TareasContext dbContext) =>
{
    var categorias = await dbContext.Categorias.ToListAsync();
    return Results.Ok(categorias);
});

//Creamos un endpoint para crear una categoria con todos sus campos
app.MapPost("/categorias", async ([FromServices] TareasContext dbContext, Categoria categoria) =>
{
    dbContext.Categorias.Add(categoria);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/categorias/{categoria.CategoriaId}", categoria);
});
//Creamos un endpoint para obtener una categoria por su id
app.MapGet("/categorias/{id}", async ([FromServices] TareasContext dbContext, string id) =>
{
    var categoria = await dbContext.Categorias.FindAsync(id);
    if (categoria == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(categoria);
});

//Creamos un endpoint para actualizar una categoria por su id
app.MapPut("/categorias/{id}", async ([FromServices] TareasContext dbContext, string id, Categoria categoria) =>
{
    if (id != categoria.CategoriaId.ToString())
    {
        return Results.BadRequest();
    }
    dbContext.Entry(categoria).State = EntityState.Modified;
    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Categorias.FindAsync(id) == null)
        {
            return Results.NotFound();
        }
        throw;
    }
    return Results.NoContent();
});

//Creamos un endpoint para eliminar una categoria por su id
app.MapDelete("/categorias/{id}", async ([FromServices] TareasContext dbContext, string id) =>
{
    var categoria = await dbContext.Categorias.FindAsync(id);
    if (categoria == null)
    {
        return Results.NotFound();
    }
    dbContext.Categorias.Remove(categoria);
    await dbContext.SaveChangesAsync();
    return Results.NoContent();
});

//Creamos un endpoint para obtener todas las tareas
app.MapGet("/tareas", async ([FromServices] TareasContext dbContext) =>
{
    var tareas = await dbContext.Tareas.ToListAsync();
    return Results.Ok(tareas);
});

//Creamos un endpoint para crear una tarea con todos sus campos
app.MapPost("/tareas", async ([FromServices] TareasContext dbContext, Tarea tarea) =>
{
    dbContext.Tareas.Add(tarea);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/tareas/{tarea.TareaId}", tarea);
});
//Creamos un endpoint para obtener una tarea por su id
app.MapGet("/tareas/{id}", async ([FromServices] TareasContext dbContext, string id) =>
{
    var tarea = await dbContext.Tareas.FindAsync(id);
    if (tarea == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(tarea);
});

//Creamos un endpoint para actualizar una tarea por su id
app.MapPut("/tareas/{id}", async ([FromServices] TareasContext dbContext, string id, Tarea tarea) =>
{
    if (id != tarea.TareaId.ToString())
    {
        return Results.BadRequest();
    }
    dbContext.Entry(tarea).State = EntityState.Modified;
    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Tareas.FindAsync(id) == null)
        {
            return Results.NotFound();
        }
        throw;
    }
    return Results.NoContent();
});

//Creamos un endpoint para eliminar una tarea por su id
app.MapDelete("/tareas/{id}", async ([FromServices] TareasContext dbContext, string id) =>
{
    var tarea = await dbContext.Tareas.FindAsync(id);
    if (tarea == null)
    {
        return Results.NotFound();
    }
    dbContext.Tareas.Remove(tarea);
    await dbContext.SaveChangesAsync();
    return Results.NoContent();
});
app.Run();
