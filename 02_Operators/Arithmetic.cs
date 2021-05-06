using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum); //37

            int difference = a - b;
            Console.WriteLine(difference); //37

            int product = a * b;
            Console.WriteLine(product); //330

            int quotient = a / b;
            Console.WriteLine(quotient); //1 only the whole number. instead of using int, use double

            int remainder = a % b; //only the remainder
            Console.WriteLine(remainder); // 7


        }
    }
}
