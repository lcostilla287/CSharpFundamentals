using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = age == 41; // would display false because age is not 25

            bool userIsMichael = userName == "Michael"; //displays false because it is not jacob

            Console.WriteLine(isEqual);
            Console.WriteLine(userIsMichael);

            bool isNotEqual = age != 23; // != means not equal

            Console.WriteLine(isNotEqual); // displays true because it is not 25

            List<string> firstList = new List<string>(); //make sure to take care of the List word add the using statement can use dropdown on lightbulb
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual); // is false because they are stored in different places so not exact same

            bool isGreaterThan = age > 26;
            Console.WriteLine(isGreaterThan); // false

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); //true

            bool isGreaterOrEqual = age >= 41;
            Console.WriteLine(isGreaterOrEqual); //False

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse; // false because is both variables aren't true

            bool anotherAndValue = (age == 25 && userName == "Jacob"); // true
            bool orValue = (age == 25 || userName == "Michael"); //true || means or

        }
    }
}
