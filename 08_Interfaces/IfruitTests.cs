using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IfruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            Ifruit banana = new Banana();
            Banana banana1 = new Banana();
            //Can't create interface object like below
            //Ifruit banana = new Ifruit();

            // var is like a wildcard argument-takes in anything and interprets it as whatever
            var output = banana.Peel(); // in this case, var would interpret as a string
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollection()
        {
            Orange orange = new Orange(); //if we use Ifruit we lose the squeezed

            //var allows diff fruits using Ifruit interface to exist together
            var fruitsalad = new List<Ifruit>
            {
                new Banana(),
                new Orange(),
                orange
            };
            //Orange exclusive methods still accessible outside of Ifruit collection

            foreach (var fruit in fruitsalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                //no longer accessible once in a collection
                //fruit.squeeze

                Assert.IsInstanceOfType(fruit, typeof(Ifruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(Ifruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            //Even though the method only takes Ifruit, grape still qualifies
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<Ifruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                //checking its of type orange, casting it as orange
                //pattern Matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        //Regain orange exclusive properties
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape");
                    // without pattern matching, cast is necessary
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a banana");
                }

            }
        }
    }
}
