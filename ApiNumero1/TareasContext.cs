using Microsoft.EntityFrameworkCore;
using APiNumero1.Models;
namespace APiNumero1{
    public class TareasContext : DbContext{
        public TareasContext(DbContextOptions<TareasContext> options) : base(options){
        }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}