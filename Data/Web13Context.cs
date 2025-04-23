using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web13.Models;

namespace Web13.Data
{
    public class Web13Context : DbContext
    {
        public Web13Context (DbContextOptions<Web13Context> options)
            : base(options)
        {
        }

        public DbSet<Web13.Models.Product> Product { get; set; } = default!;
        public DbSet<Web13.Models.User> User { get; set; } = default!;
    }
}
