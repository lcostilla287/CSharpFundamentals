using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MorningChallenge_W3D1
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cars = new List<IVehicle> 
            {
                new Jeep(true, true),
                new Jeep(true, false),
                new JunkCar(),
                new JunkCar(true, true)

            };

            foreach(var vehicle in cars)
            {
                if (vehicle is Jeep jeep)
                {
                    if (jeep.CanStart)
                    {
                        Console.WriteLine(jeep.CanDrive());
                    }
                    else
                    {
                        Console.WriteLine(jeep.CanDrive());
                    }
                }
                else
                {
                    if (vehicle is JunkCar junkCar)
                    {
                        if(junkCar.CanStart)
                        {
                            Console.WriteLine(junkCar.CanDrive());
                        }
                        else
                        {
                            Console.WriteLine(junkCar.CanDrive());
                        }
                    }
                }
            }
        }
    }
}
