using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;

            bool isAdult = age > 17 ? true : false; // evaluates then sees if it is true or false
            Console.WriteLine(isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20; //evaluates, if true then 30 if not then 20
            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");
        }
    }
}
