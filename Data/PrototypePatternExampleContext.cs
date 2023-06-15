using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrototypePatternExample.Models;

namespace PrototypePatternExample.Data
{
    public class PrototypePatternExampleContext : DbContext
    {
        public PrototypePatternExampleContext (DbContextOptions<PrototypePatternExampleContext> options)
            : base(options)
        {
        }

        public DbSet<PrototypePatternExample.Models.Car> Car { get; set; } = default!;
    }
}
