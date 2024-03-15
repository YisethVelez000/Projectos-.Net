using ApiExportacion.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExportacion
{
    public class ExportacionContext : DbContext
    {
        public DbSet<Exportacion> Exportaciones { get; set; }
        public ExportacionContext(DbContextOptions<ExportacionContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Exportacion = modelBuilder.Entity<Exportacion> (Exportacion =>{
                Exportacion.HasKey(e => e.ProductoId);
                Exportacion.Property(e => e.ProductoNombre).IsRequired();
                Exportacion.Property(e => e.Kilos).IsRequired();
                Exportacion.Property(e => e.PrecioKilo).IsRequired();
                Exportacion.Property(e => e.PrecioDolar).IsRequired();
            }
            );

        }

    }
}