using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_mvc_country_state_city_Register.Models
{
    public class State
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country country { get; set; }
    }
}