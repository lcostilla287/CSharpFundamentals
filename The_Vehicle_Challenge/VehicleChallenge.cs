using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Vehicle_Challenge
{
    public enum VehicleType { SUV, Plane, Boat } // VehicleType is new type?
    public class VehicleChallenge
    {
        public string Make { get; set; }
        public string Model { get; set; }  //These are properties of the class VehicleChallenge?
        public VehicleType TypeOfVehicle { get; set; }  //give the type a name?
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void MyVehicleTest()
        {

        }
    }
}
