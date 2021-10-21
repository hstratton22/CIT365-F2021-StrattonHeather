using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie3.Models;

namespace RazorPagesMovie3.Data
{
    public class RazorPagesMovie3Context : DbContext
    {
        public RazorPagesMovie3Context (DbContextOptions<RazorPagesMovie3Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie3.Models.Movie> Movie { get; set; }

        public DbSet<RazorPagesMovie3.Models.Hymn> Hymn { get; set; }
    }
}
