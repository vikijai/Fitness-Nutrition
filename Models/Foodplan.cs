using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class Foodplan
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Dietplan { get; set; }
        public string Workoutplan { get; set; }
        public string Healthyrecipes { get; set; }
    }
}