using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeskExperiment.Models;

namespace DeskExperiment.Data
{
    public class DeskExperimentContext : DbContext
    {
        public DeskExperimentContext (DbContextOptions<DeskExperimentContext> options)
            : base(options)
        {
        }

        public DbSet<DeskExperiment.Models.DeskQuote> DeskQuote { get; set; }
    }
}
