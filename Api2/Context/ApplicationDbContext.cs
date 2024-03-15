using Api2.Models;
using Microsoft.EntityFrameworkCore;
namespace Api2.Context
{
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
        }
}
