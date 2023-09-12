using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_City_Country_state_register4.Models
{
    public class Register
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public GenderType Gender { get; set; }

        public bool Subscribe { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [NotMapped]
        [Display (Name ="State")]
        public int StateId { get; set; }

        [NotMapped]
        [Display (Name ="Country")]
        public int CountryId { get; set; }
    }
}