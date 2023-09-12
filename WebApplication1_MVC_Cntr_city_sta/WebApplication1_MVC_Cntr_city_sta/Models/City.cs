using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Cntr_city_sta.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }
    }
}