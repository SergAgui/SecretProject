using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupApp.Models
{
    public class Locations 
    {
        public int? Id { get; set; }
        public List<NorthLocations> NorthLocations { get; set; }
        public List<CentralLocations> CentralLocations { get; set; }
        public List<SouthLocations> SouthLocations { get; set; }
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }

    }
}
