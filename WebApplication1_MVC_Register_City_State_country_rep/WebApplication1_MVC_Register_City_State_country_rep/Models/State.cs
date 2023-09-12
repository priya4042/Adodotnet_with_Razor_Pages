using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Register_City_State_country_rep.Models
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}