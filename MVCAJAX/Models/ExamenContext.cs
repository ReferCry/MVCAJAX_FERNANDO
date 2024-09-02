using Microsoft.EntityFrameworkCore;
using MVCAJAX_FERNANDO.Models;

namespace MVCAJAX_FERNANDO.Models
{
    public class ExamenContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) 
        { 
        }
    }
}
