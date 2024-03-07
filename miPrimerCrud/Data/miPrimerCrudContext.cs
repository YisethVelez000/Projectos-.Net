using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using miPrimerCrud.Models;

namespace miPrimerCrud.Data
{
    public class miPrimerCrudContext : DbContext
    {
        public miPrimerCrudContext (DbContextOptions<miPrimerCrudContext> options)
            : base(options)
        {
        }

        public DbSet<miPrimerCrud.Models.Peliculas> Peliculas { get; set; } = default!;
    }
}
