using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_mvc_country_state_city_Register.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}