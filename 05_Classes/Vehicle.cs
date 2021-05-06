using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter} //this show the required values if you want vehicletype
    public class Vehicle  //public is access modifier; specifies visibility to other classes vehicle is custom class
    {
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle) //(constructor) in the method
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            typeOfVehicle = typeOfVehicle;
        }

        public Vehicle() { } //overload = more than once

        // 1 Access Modifier
        //2 Type = type property can hold
        //3 Name
        //4 Getters and setters

        //1     2       3       4
        public string Make { get; set; }
        public string Model { get; set; } //these are properties
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool isRunning { get; private set; }

        public void TurnOn()
        {
            isRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }

        public void TurnOff()
        {
            isRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public bool RightIndicator { get; private set; }

        public bool LeftIndicator { get; private set; } //prop tab tab is autofill

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
            // LeftIndicator.Turn
        }

        //Challenge
        //make Indicator it's own custom class
        //properties including IsFlashing
        //method for Turn on() and TurnOff()
        // - methods would set value of IsFlashing
    }

    public class Indicator
    {
        public bool isFlashing { get; private set; } //can set private only within Indicator class

        public void TurnOn()
        {
            isFlashing = true;
        }

        public void TurnOff()
        {
            isFlashing = false;
        }
    }
}
