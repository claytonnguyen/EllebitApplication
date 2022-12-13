using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EllebitApplication.Models;

namespace EllebitApplication.Data
{
    public class EllebitApplicationContext : DbContext
    {
        public EllebitApplicationContext (DbContextOptions<EllebitApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<EllebitApplication.Models.Restaurant> Restaurant { get; set; } = default!;
    }
}
