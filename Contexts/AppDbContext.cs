using api_rest.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options):base(options)
        {

        }
        public DbSet<Producto> Producto{ get; set; }
    }
}
