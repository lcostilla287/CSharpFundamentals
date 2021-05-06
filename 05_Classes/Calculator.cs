using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public double Addition(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution; // can shorthand everything here to return numOne + numTwo
        }

        //subtraction
        //multiplication
        //division


        public int CalculateAge(DateTime birthday)
        {
            
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears)); //Convert rounds down
            return years;
        }
    }
}
