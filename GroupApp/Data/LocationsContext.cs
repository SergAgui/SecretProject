using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupApp.Models
{
    public class LocationsContext : DbContext
    {
        public LocationsContext (DbContextOptions<LocationsContext> options)
            : base(options)
        {
        }

        public DbSet<GroupApp.Models.Locations> Locations{ get; set; }
        public DbSet<GroupApp.Models.User> User { get; set; }
    }
}
