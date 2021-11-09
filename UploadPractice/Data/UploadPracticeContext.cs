using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UploadPractice.Models;

namespace UploadPractice.Data
{
    public class UploadPracticeContext : DbContext
    {
        public UploadPracticeContext (DbContextOptions<UploadPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<UploadPractice.Models.Movie> Movie { get; set; }
    }
}
