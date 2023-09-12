using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC__ctry_cpuny.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public GenderType gender { get; set; }

        public bool Subscribe { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [NotMapped]
        [Display(Name ="State")]
        public int StateId { get; set; }

        [NotMapped]
        [Display(Name ="Country")]
        public int CountryId { get; set; }
    }
}