using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroupApp.Models
{
    public class NorthLocations
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