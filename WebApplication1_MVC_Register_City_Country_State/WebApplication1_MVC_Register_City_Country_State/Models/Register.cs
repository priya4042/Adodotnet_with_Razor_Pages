using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Register_City_Country_State.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Name Required")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Address Required")]
        public string Address { get; set; }

        [Required (ErrorMessage ="Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Gender Required")]
        public GenderType Gender { get; set; }

        [Required (ErrorMessage ="Subscribe Required")]
        public bool Subscribe { get; set; }

        [Required (ErrorMessage ="City Required")]
        [Display(Name ="City")]
        public string CityId { get; set; }

        [NotMapped]
        [Required (ErrorMessage ="State Required")]
        [Display(Name ="State")]
        public string StateId { get; set; }

        [NotMapped]
        [Required (ErrorMessage ="Country Required")]
        [Display(Name ="Country")]
        public string CountryId { get; set; }
    }
}