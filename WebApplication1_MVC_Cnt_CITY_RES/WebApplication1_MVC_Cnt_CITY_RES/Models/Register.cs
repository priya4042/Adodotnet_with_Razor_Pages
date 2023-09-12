using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Cnt_CITY_RES.Models
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

        public GenderType Gender { get; set; }

        public bool Subscribe { get; set; }

        [Display(Name = "State")]
        public int CityId { get; set; }

        public City City { get; set; }

        [NotMapped]
        [Display(Name="State")]
        public int StateId { get; set; }

        [Display(Name = "State")]
        [NotMapped]
        public int CountryId { get; set; }
    }
}