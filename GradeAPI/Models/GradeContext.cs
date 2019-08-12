using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeAPI.Models
{
    public class GradeContext : DbContext
    {
        public GradeContext(DbContextOptions<GradeContext> options)
            : base(options)
        {
        }

        public DbSet<GradeItem> GradeItems { get; set; }
    }
}
