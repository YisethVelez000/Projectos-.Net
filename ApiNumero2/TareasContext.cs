using Microsoft.EntityFrameworkCore;
using ApiNumero2.Models;
namespace ApiNumero2{
    public class TareasContext : DbContext{
        
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
public TareasContext(DbContextOptions<TareasContext> options) : base(options){
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var Categoria = modelBuilder.Entity<Categoria>( categoria =>{
            categoria.ToTable("Categoria"); //Crear la tabla categoria
            categoria.HasKey(p=> p.CategoriaId);
            categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p=>p.Descripcion);
            }

            );

            var Tarea = modelBuilder.Entity<Tarea>( tarea=>{
            tarea.ToTable("Tarea"); //Crear la tabla tarea
            tarea.HasKey(p=>p.TareaId); 
            tarea.HasOne(p=>p.Categoria).WithMany(p=>p.Tareas).HasForeignKey(p=>p.CategoriaId);
            tarea.Property(p=>p.Titulo).IsRequired().HasMaxLength(150);
            tarea.Property(p=>p.Descripcion);
            tarea.Property(p=>p.FechaCreacion);
            tarea.Property(p=>p.PrioridadTarea);
            tarea.Ignore(p=>p.Resumen);
            }
            );
        }
    }
}