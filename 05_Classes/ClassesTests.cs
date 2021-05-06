using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.isRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.isRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            //cannot be set outside of class
            Indicator indicator = new Indicator(); // all of this acesses the indicator class keeps it seperate from others
            Console.WriteLine(indicator.isFlashing);  //auto false
            indicator.TurnOn();
            Console.WriteLine(indicator.isFlashing);
        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan"; // have to manually do all of this if there is no constructor
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model); //concatenation

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 1000000, VehicleType.Plane); //can do this if there is a constructor (much easier!)
            Console.WriteLine($"I rode on a spaceship, it was the {rocket.Make}"); //interpolation

            rocket.Model = "Constelation";

            Console.WriteLine($"That ship is a {rocket.Model}");
        }

        //Greeter
        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>(); //make sure to do the assign thing ()
            students.Add("Hannah");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach(string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.Addition(3.5, 100.9); //addition class
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1988, 04, 11)); //year month date // calculate age class
            Console.WriteLine(age);
        }

        //Person

        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Michael", "Pabody", new DateTime(2000, 01, 31)); //initial data

            Console.WriteLine(person.FirstName + " " + person.LastName);

            Console.WriteLine(person.FullName);

            Console.WriteLine(person.Age);

            //blank constructor() can have missing data if you don't complete the long way
            Person jake = new Person(); // if you keep ()empty you have to do it the long way
            jake.FirstName = "Jacob";
            jake.DateOfBirth = new DateTime(1991, 05, 04);
            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Age);

            //useful in blue and red, can do this  to assign this stuff to an empty constructor()
            Person andrew = new Person()
            {
                FirstName = "Andrew" ,
                LastName = "Torr",
                DateOfBirth = new DateTime (1950, 12, 25)
            };

            //Asserting with a test that these two are equal
            //Assert.AreEqual("Jacob", jake.FirstName);
            //Asserting that these are not equal (wait a while for it to update
            //Assert.AreNotEqual("Jacob", jake.FirstName);
            //we expect the failure
        }
        //this space here is in the namespace but out of method
        //the methods can see stuff here
        //a test method cannot see anything in another method

        //this here is a Field type variable
        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));
        [TestMethod]
        public void PersonTransportTest()
        {
            //this stuff refers to the stuff just before this method
            _person.Transport = new Vehicle("X-Wing", "Starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make} {_person.Transport.Model}");

            _person.Transport.Make = "T16 Skyhopper"; 

            Console.WriteLine(_person.Transport.Make);
            //put the first Console.WriteLine and it will update the info


            Person blank = new Person();
            Console.WriteLine($"Fullname: {blank.FullName}"); // we get nothing because fullname of blank is nothing

            Console.WriteLine($"Unset class: {blank.Transport}"); //get nothing because blank has nothing
            Console.WriteLine($"Unset struct; {blank.DateOfBirth}"); //struct is a little different
            Console.WriteLine($"Age: {blank.Age}"); // displays 2020 because no data is passed through
        }
    }   
}
