using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_W2D2
{
    public class Calculator
    {

        //maybe i can do private calculator number; to make newing up a little easier (in unit tests)
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Add 
        { 
            get 
            {
                return FirstNumber + SecondNumber;
            } 
        }
        public double Subtraction
        {
            get
            {
                return FirstNumber - SecondNumber;
            }
        }
        public double Multiplication
        {
            get
            {
                return FirstNumber * SecondNumber;
            }
        }
        public double Division 
        { 
            get 
            {
                return FirstNumber / SecondNumber;
            }
        }

        public string Percent //example of percentage definitely need to revisit this concept
        {
            get
            {
                double c = FirstNumber / SecondNumber;
                    c *= 100;
                return $"{c}";
            }
        }


        public double AddConstantly(double[] numbers) // example that should be recoded
        {
            double total = 0;
                foreach (double number in numbers)
            {
                total += number;
            }
            return total;
        }
    }
}
