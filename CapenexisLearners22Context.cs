using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners22.Models;

namespace CapenexisLearners22.Data
{
    public class CapenexisLearners22Context : DbContext
    {
        public CapenexisLearners22Context (DbContextOptions<CapenexisLearners22Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners22.Models.Facilitator> Facilitator { get; set; } = default!;

        public DbSet<CapenexisLearners22.Models.Learner> Learner { get; set; } = default!;

        public DbSet<CapenexisLearners22.Models.Courses> Course { get; set; } = default!;

        
    }
}
