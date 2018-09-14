using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroupApp.Models;

namespace GroupApp.Models
{
    public class SouthLocationsContext : DbContext
    {
        public SouthLocationsContext (DbContextOptions<SouthLocationsContext> options)
            : base(options)
        {
        }

        public DbSet<GroupApp.Models.SouthLocations> SouthLocations { get; set; }

        public DbSet<GroupApp.Models.User> User { get; set; }
    }
}
