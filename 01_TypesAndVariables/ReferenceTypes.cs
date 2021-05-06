using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Luis"; //type name value
            string lastName = "Costilla";

            //Concatenation
            string concatenatedFullName = firstName + ' ' + lastName; // ' ' adds a space
            Console.WriteLine(concatenatedFullName);

            //Compositing
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(compositeFullName); // displays similarly to concatenation can also use a 2 but needs to be defined if haven't already in ""

            //Interpolation
            string interpolatedFullName = $"{firstName} \" The Goat\" {lastName} is the best"; // \" displays the quote $ defines as string
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "why", "is it", "always", stringExample, "?" }; //arrays only hold 1 type. like this string. curly braces tell them to go in brackets 

            string interpolatedStrings = $"{stringArray[0]} {stringArray[2]}"; //brings out the first word in the last line
            Console.WriteLine(interpolatedStrings);

            string firstString = stringArray[0];

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfIntegers.Add(23);
            listOfStrings.Add("World");

            Console.WriteLine(listOfIntegers[0]);
            Console.WriteLine(listOfStrings[1]);
            listOfStrings.Remove(listOfStrings[0]);
            Console.WriteLine(listOfStrings[0]);

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>(); //like people in line
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string whosFirst = firstInFirstOut.Peek();
            Console.WriteLine(whosFirst);
            string firstItem = firstInFirstOut.Dequeue(); //Takes it out of the queue
            Console.WriteLine(firstItem); // looks at what we took out of queue
            string whosFirstNow = firstInFirstOut.Peek(); //sees what is in the queue
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>(); //key, value

            keyAndValue.Add(001, "EFA office");

            string badgeDoor = keyAndValue[001]; //put in the actual key (first value) not second (value)

            Console.WriteLine(badgeDoor);

            //Checkout some stuff
            //SortedList
            //HashSet
            //Stack
        }
        
    }
}
