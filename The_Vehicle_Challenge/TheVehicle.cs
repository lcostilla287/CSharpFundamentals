using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Vehicle_Challenge
{
    [TestClass]
    public class TheVehicle
    {
        [TestMethod]
        public void MyActualVehicle()
        {
            VehicleChallenge myVehicle = new VehicleChallenge(); //the type is Vehicle challenge from vehicle challenge class?
            //we made myVehicle a local variable now

            myVehicle.Make = "Jeep"; //I forget what this does 
            Console.WriteLine(myVehicle.Make); //displays Jeep

            myVehicle.Model = "Liberty";
            Console.WriteLine(myVehicle.Model); //Displays Liberty

            myVehicle.TypeOfVehicle = VehicleType.SUV; //idk
            Console.WriteLine(myVehicle.TypeOfVehicle); //displays SUV
        }
    }
}
