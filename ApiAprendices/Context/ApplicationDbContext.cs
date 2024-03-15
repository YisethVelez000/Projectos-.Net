
using Microsoft.EntityFrameworkCore;
using ApiAprendices.Models;

namespace ApiAprendices.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
