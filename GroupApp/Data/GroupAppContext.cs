using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupApp.Models
{
    public class GroupAppContext : DbContext
    {
        public GroupAppContext (DbContextOptions<GroupAppContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<CentralLocations> CentralLocations { get; set; }
        public DbSet<NorthLocations> NorthLocations { get; set; }
        public DbSet<SouthLocations> SouthLocations { get; set; }
    }
}
