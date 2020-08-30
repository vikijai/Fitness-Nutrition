using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class BmiContext:DbContext
    {
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Foodplan> Foodplan { get; set; }
        public DbSet<Signup> Signup { get; set; }
        
    }
}