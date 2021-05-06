using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;


            isDeclared = true; // initializing the variable

            bool isDeclaredAndInitialized = false; // both declared and initiallized
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numbserCharacter = '7';
            char symbol = '#';
            char space = ' ';
            char specialCharacter = '\n'; // line return \t is tab
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255; //max values are initiallized
            short shortExample = 32767;
            Int16 anotherShortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 2; //giant number
            Int64 longmin = -2; //reverse giant number
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.54322346234523462342346252f; //make sure to have f
            double doubleExample = 1.54322346234523462342346252d; //d suffix is optional
            decimal decimalExample = 1.54322346234523462342346252m; //use m suffix!

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclair, Danish, Canoli } //Make your own type!

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclair;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today); // Just today's date
            Console.WriteLine(DateTime.Now); // Today's Date with time
            DateTime birthday = new DateTime(1997, 09, 06); //created a new variable with that value

            TimeSpan age = today - birthday; //Tells your age
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }

        [TestMethod]
        public void HowOld(DateTime birthday)
        {
            //DateTime birthday = new DateTime(1997, 09, 06);
            TimeSpan agespan = DateTime.Now - birthday;
            double totalAgeInDays = agespan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            Console.WriteLine(years);

        }
        [TestMethod]
        public int Method(string aWord)
        {
            int nowAnInt = Int32.Parse(aWord);
            return nowAnInt;
        }

        [TestMethod]
        public double Division(int numOne, int numTwo)
        {
            double first = Convert.ToDouble(numOne);
            double second = Convert.ToDouble(numTwo);
            double quotient = first / second;
            return quotient;
        }

        [TestMethod]
        public int Greatest(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }
        }

        [TestMethod]
        public void FizzBuzzMethod(int highNumber)
        {
            for (int i = 1; i <= highNumber; i++)

            {

                if (i % 15 == 0)

                {

                    Console.WriteLine("FizzBuzz");

                }

                else if (i % 3 == 0)

                {

                    Console.WriteLine("Fizz");

                }

                else if (i % 5 == 0)

                {

                    Console.WriteLine("Buzz");

                }

                else

                {

                    Console.WriteLine(i);

                }

            }
        }
    }
}
