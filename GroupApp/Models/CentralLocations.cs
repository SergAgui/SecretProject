using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroupApp.Models
{
    public class CentralLocations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Establishment { get; set; }

        public string Address { get; set; }

        [Required]
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }

        public string Thoughts { get; set; }
    }
}