using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_City_Country_state_register4.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Here Name Required")]
        public string Name { get; set; }

    }
}