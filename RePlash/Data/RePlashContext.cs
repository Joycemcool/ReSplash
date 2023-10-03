using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RePlash.Models;

namespace RePlash.Data
{
    public class RePlashContext : DbContext
    {
        public RePlashContext (DbContextOptions<RePlashContext> options)
            : base(options)
        {
        }

        public DbSet<RePlash.Models.Photo> Photo { get; set; } = default!;
    }
}
