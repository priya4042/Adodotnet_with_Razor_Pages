using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Register_City_Country_State.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }
    }
}