using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenge_W2D2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            Calculator addition = new Calculator();
            addition.FirstNumber = 5;
            addition.SecondNumber = 6;
            Console.WriteLine(addition.Add);
            Assert.AreEqual(addition.FirstNumber + addition.SecondNumber, addition.Add);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Calculator subtraction = new Calculator();
            subtraction.FirstNumber = 12;
            subtraction.SecondNumber = 3;
            Console.WriteLine(subtraction.Subtraction);
            Assert.AreEqual(subtraction.FirstNumber - subtraction.SecondNumber, subtraction.Subtraction);
        }
        
        [TestMethod]
        public void MultiplicationTest()
        {
            Calculator multiplication = new Calculator();
            multiplication.FirstNumber = 3;
            multiplication.SecondNumber = 7;
            Console.WriteLine(multiplication.Multiplication);
            Assert.AreEqual(multiplication.FirstNumber * multiplication.SecondNumber, multiplication.Multiplication);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Calculator division = new Calculator();
            division.FirstNumber = 30;
            division.SecondNumber = 3;
            Console.WriteLine(division.Division);
            Assert.AreEqual(division.FirstNumber / division.SecondNumber, division.Division);
        }
    }
}
