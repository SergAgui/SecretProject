using System;
<<<<<<< HEAD
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel;
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
using System.Linq;
using System.Threading.Tasks;
=======
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
>>>>>>> fb9284e99864479f00fb130461a796798f43899e

namespace GroupApp.Models
{
    public class CentralLocations
    {
<<<<<<< HEAD
<<<<<<< HEAD
        [Key]
=======
        
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
=======
        [Key]
>>>>>>> fb9284e99864479f00fb130461a796798f43899e
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Establishment { get; set; }

        public string Address { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        [Required]
        public DateTime DateTime { get; set; }
        public string Thoughts { get; set; }
=======
        public string Thoughts { get; set; }
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }

>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
=======

        [Required]
        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }

        public string Thoughts { get; set; }
>>>>>>> fb9284e99864479f00fb130461a796798f43899e
    }
}