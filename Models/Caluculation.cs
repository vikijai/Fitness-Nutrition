using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
    public class Caluculation
    {
        public int Calc(double bmivalue, int age)
        {
            int id = 0;

            if (bmivalue < 18.5)
            {
                if (age < 80)
                {
                    id = 1;
                }
                else
                {
                    id = 5;
                }
            }
            else if (bmivalue >= 18.5 && bmivalue <= 24.9)
            {
                if (age < 80)
                {
                    id = 2;
                }
                else
                {
                    id = 6;
                }
            }
            else if (bmivalue >= 25.0 && bmivalue <= 29.9)
            {
                if (age < 80)
                {
                    id = 3;
                }
                else
                {
                    id = 7;
                }
            }
            else if(bmivalue>30)
            {
                if (age < 80)
                {
                    id = 4;
                }
                else
                {
                    id = 8;
                }
            }
            else
            {
                id = 0;
            }
            return id;
        }
    }
}