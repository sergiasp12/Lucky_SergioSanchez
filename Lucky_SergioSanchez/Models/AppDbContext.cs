using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_SergioSanchez.Models
{
    public class AppDbContext:DbContext
    {
        internal object lucky;

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
                
        }
        public DbSet<Lucky> Lucky { get; set; }

    }
}
