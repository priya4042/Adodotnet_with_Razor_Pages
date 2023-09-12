using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_country_city_state_5.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }
    }
}