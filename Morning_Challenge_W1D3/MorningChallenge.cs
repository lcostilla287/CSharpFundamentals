using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Morning_Challenge_W1D3
{
    [TestClass]
    public class MorningChallenge
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "supercalifragilisticexpialidocious"; //this be my string

            int namelength = value.Length;  //This makes the length of the string numerical (scroll to bottom of method)
            foreach (char c in value)
            {
                //Console.WriteLine(c); //this displays each character on each line

                if (c is('i')) // checks to see if the character is an 'i'  double quotes for string, single for characters can also use (c == 'i')
                {
                    Console.WriteLine(c);
                }

                else if (c is ('l')) // checks to see if character is an 'l'
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("not an i or l");
                }
            }
            Console.WriteLine(namelength); //this desplays total characters can also do namelength.Length
        }

        [TestMethod]
        public void OtherMorningChallenge()
        {
            string firstName = "Luis";
            string lastName = "Costilla";
            int myAge = 23;

            string[] favorites = { "The Incredibles", "A Tale Dark and Grim", "Tom and Jerry", "The Avengers" }; //this be an array. this contains multiple strings

            //list is kind of array

            List <DateTime> specificDate = new List<DateTime>(); //startup to creating a specific list
            specificDate.Add(new DateTime(2000, 10, 20)); //goes year, month, day. This needs the "new" keyword
            specificDate.Add(new DateTime(1999, 9, 9));
            specificDate.Add(DateTime.Now);

            int add = age + 7;
            int sub = myAge - 7;
            int mul = myAge * 7;
            int quo = myAge / 7;
            Console.WriteLine($"{add} {sub} {mul} {quo}");

        }

        [TestMethod]
        public void SleepTime()
        {
            int time = 8;

            if(time >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep!");
            }
            else if (time >= 8 && time < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (time > 4 && time < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man! Get some sleep!");
            }

            int happinessIndex = 3;
            switch (happinessIndex)
            {
                case 1:
                    Console.WriteLine("Bad");
                    break;
                case 2:
                    Console.WriteLine("Okay");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                case 4:
                    Console.WriteLine("Great");
            }
        }
    }
}
