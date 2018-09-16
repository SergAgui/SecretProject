using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupApp.Models
{
    public class NorthLocationsContext : DbContext
    {
        public NorthLocationsContext (DbContextOptions<NorthLocationsContext> options)
            : base(options)
        {
        }

        public DbSet<GroupApp.Models.NorthLocations> NorthLocations { get; set; }
    }
}
