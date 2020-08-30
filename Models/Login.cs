using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

    }
}