using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EKebun.Models
{
    public class EKebunJobContext : DbContext
    {
        public EKebunJobContext (DbContextOptions<EKebunJobContext> options)
            : base(options)
        {
        }

        public DbSet<EKebun.Models.Job> Job { get; set; }
    }
}
