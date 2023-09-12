using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Country_State_City_Registration2.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}