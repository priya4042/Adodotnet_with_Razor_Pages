using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Cntr_city_sta.Models
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
        public GenderType Gender { get; set; }
        [Required]
        
        public bool Subscribe { get; set; }
        [Required]
        
        public int CityId { get; set; }

        
        public City City { get; set; }

        [NotMapped]
        [Required]
        public int StateId { get; set; }

        [NotMapped]
        [Required]
        public int CountryId { get; set; }

    }
}