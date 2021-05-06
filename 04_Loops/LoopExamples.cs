using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.WriteLine(someCount); //take out line and it will display in one line. " " + somecount adds a space
                    someCount++; //same as sameCount = someCount + 1;
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;


            //1 Start
            //2 Condition
            //3 What to do after each loop
            //4 Body- what gets executed each loop

                    //1          //2            /3
            for (int i = 0; i < studentCount; i++) //++i adds one before and will go 1-28 the check is after
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Aaron", "Alexandro", "Andrew", "Ben", "Chris" };


            //1 Collection being worked on
            //2 name of current iteration
            //3 Type that is held in the collection
            //4 in keyword
                      //3       //2 //4   //1
            foreach (string student in students)
            {
                Console.WriteLine(student + "is a student in this class");
            }

            string myName = "Luis Costilla";

            foreach (char letter in myName)
            {
                Console.WriteLine(letter); //instead of writline put write so it can be on one line
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine(iterator);  //this section goes first then runs the while check
                iterator++;
            }
            while (iterator < 5);
        }
    }
}
