using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }
       
        public string Gender { get; set; }
        [Required(ErrorMessage = "Height is Required")]      
        public int Height { get; set; }
        [Required(ErrorMessage = "Weight is Required")]
        public int Weight { get; set; }
        public double Bmivalue { get; set; }
        
    }
}