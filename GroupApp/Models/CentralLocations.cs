using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel;
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
using System.Linq;
using System.Threading.Tasks;

namespace GroupApp.Models
{
    public class CentralLocations
    {
<<<<<<< HEAD
        [Key]
=======
        
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Establishment { get; set; }
        public string Address { get; set; }
<<<<<<< HEAD
        [Required]
        public DateTime DateTime { get; set; }
        public string Thoughts { get; set; }
=======
        public string Thoughts { get; set; }
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }

>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
    }
}
