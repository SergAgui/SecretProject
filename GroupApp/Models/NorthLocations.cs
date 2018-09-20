using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GroupApp.Models
{
    public class NorthLocations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Establishment { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public string Thoughts { get; set; }
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }
    }
}
