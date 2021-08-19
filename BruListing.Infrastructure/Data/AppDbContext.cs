using BruListing.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruListing.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs{ get; set; }
        public DbSet<PrimaryTag> PrimaryTags{ get; set; }
    }
}
