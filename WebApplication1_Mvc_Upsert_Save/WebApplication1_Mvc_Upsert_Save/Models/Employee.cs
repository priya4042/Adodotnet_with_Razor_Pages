using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication1_Mvc_Upsert_Save.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }

        [Range(15000,150000,ErrorMessage ="salary between 15000to150000")]
        public int Salary { get; set; }
    }
}