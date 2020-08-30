using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace FitnessApp.Controllers
{
    public class BMIController : Controller
    {
        BmiContext context = new BmiContext();
        public ActionResult Home()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if(ModelState.IsValid)
            {

                var log = context.Login.Where(a => a.Username == login.Username && a.Password == login.Password).FirstOrDefault();
                if(log == null)
                {
                        ModelState.AddModelError("userpassexist", "Invalid Username and Password");
                        return View(login);
                }
                return View("Index");
            }
            return View("Login");
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Signup obj)
        {
            try
            {
                Signup signup = new Signup();
                Login login = new Login();
                if (ModelState.IsValid)
                {

                    var isvalids= context.Signup.Where(a => a.Username == obj.Username).FirstOrDefault();
                    if (isvalids != null)
                    {
                        ModelState.AddModelError("userexist","Username already exist");
                        return View(obj);
                    }
                    signup.Username = obj.Username;
                    signup.Password = obj.Password;
                    signup.ConfirmPassword = obj.ConfirmPassword;
                    context.Signup.Add(signup);
                    login.Username = obj.Username;
                    login.Password = obj.Password;
                    context.Login.Add(login);
                    context.SaveChanges();
                    return View("Login");    
                }
                
                return View("Signup");
            }
             catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return View("Signup");
              
        }

        // GET: BMI
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserDetail userDetail)
        {
            try {
                Caluculation caluculation = new Caluculation();
                if (userDetail.Id == 0)
                {
                    int age = userDetail.Age;
                    int Height = userDetail.Height;
                    int Weight = userDetail.Weight;

                    double height_temp = (double)Height / (double)100;
                    double height_double = height_temp * height_temp;
                    double bmivalue =((double)Weight) / height_double;

                    int temp=caluculation.Calc(Math.Round(bmivalue,1),age);
 
                    userDetail.Bmivalue = bmivalue;  
                    context.UserDetails.Add(userDetail);
                    context.SaveChanges();

                   return RedirectToAction("ViewDetails", new { id = temp,disp=bmivalue });
                }
                
                
                  
                }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return View("Index");
               
        }
        public ActionResult ViewDetails(int id,double disp)
        {
            ViewData["Display"] = " Bmi Value is " +Math.Round(disp,1);
            var b = context.Foodplan.Where(a => a.Id == id).ToList();
            return View(b);
        }
       
    }
}
