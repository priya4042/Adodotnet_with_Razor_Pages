using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1_MVC_Cntr_city_sta.Models
{
    public class State
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}