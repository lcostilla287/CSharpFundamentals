using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenge_W1D4
{
    [TestClass]
    public class Person
    {
        [TestMethod]
        public void People()
        {
            User newPerson = new User("Luis", "Costilla", 1, new DateTime(1997, 9, 6)); //pay attention to date!!!!

            Console.WriteLine(newPerson.FirstName + newPerson.LastName);

            Console.WriteLine($"{newPerson.FullName()}"); //Can also do this

            Console.WriteLine(newPerson.CalculateAge); //Can also do this

        }
    }
}
