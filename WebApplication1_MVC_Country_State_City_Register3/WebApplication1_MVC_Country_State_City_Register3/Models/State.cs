using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Country_State_City_Register3.Models
{
    public class State
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Name Required")]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}