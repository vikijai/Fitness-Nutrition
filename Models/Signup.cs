using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class Signup
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="ConformPassword is Required")] 
        [Compare("Password",ErrorMessage ="Password and ConformPassword must match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string ErrorMessage { get; set; }
      

    }
}