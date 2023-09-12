using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_country_city_state_5.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Gender Required")]
        public GenderType Gender { get; set; }

        [Required(ErrorMessage ="Subscribe Required")]
        public bool Subscribe { get; set; }

        [Display(Name ="City")]
        public int CityId { get; set; }

        [NotMapped]
        [Display(Name ="State")]
        public int StateId { get; set; }

        [NotMapped]
        [Display(Name ="Country")]
        public int CountryId { get; set; }
    }
}