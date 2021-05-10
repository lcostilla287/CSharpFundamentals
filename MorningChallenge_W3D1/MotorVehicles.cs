using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_W3D1
{
    public class Jeep : IVehicle
    {
        public Jeep() { }

        public string Make
        {
            get
            {
                return "Jeep";
            }
        }

        public string Model
        {
            get
            {
                return "Liberty";
            }
        }

        public VehicleType TypeOfVehicle
        {
            get
            {
                return VehicleType.SUV;
            }
        }
         public string Color
        {
            get
            {
                return "Red";
            }
        }
        public bool CanStart { get; private set; }
        public Jeep( bool canStart, bool canTurnOff)
        {
            CanStart = canStart;
            CanTurnOff = canTurnOff;
        }
        public string Starts()
        {
            if (CanStart)
            {
                return "You can start the car.";
            }
            else
            {
                return "The car can't start";
            }
        }
        public bool CanTurnOff { get; private set; }
        public string TurnsOff()
        {
            if (CanTurnOff)
            {
                return "You can turn off the car.";
            }
            else
            {
                return "You can't shut off the car";
            }
        }

        public string CanDrive()
        {
            if (CanStart && CanTurnOff)
            {
                return "This car is safe to drive";
            }
            else
            {
                return "This car can not turn on or off and can't drive safely.";
            }
        }

    }

    public class JunkCar : IVehicle
    {
        public JunkCar() { }
        public string Make
        {
            get
            {
                return "Chevy";
            }
        }

        public string Model
        {
            get
            {
                return "Venture";
            }
        }
        public VehicleType TypeOfVehicle
        {
            get
            {
                return VehicleType.MiniVan;
            }
        }
        public string Color
        {
            get
            {
                return "Navy Blue";
            }
        }
        public bool CanStart { get; private set; }
        public JunkCar(bool canStart, bool canTurnOff)
        {
            CanStart = canStart;
            CanTurnOff = canTurnOff;
        }
        public string Starts()
        {
            if (CanStart)
            {
                return "You can start the car.";
            }
            else
            {
                return "The car can't start";
            }
        }
        public bool CanTurnOff { get; private set; }
        public string TurnsOff()
        {
            if (CanTurnOff)
            {
                return "You can turn off the car.";
            }
            else
            {
                return "You can't shut off the car";
            }
        }

        public string CanDrive()
        {
            if(CanStart && CanTurnOff)
            {
                return "This car is safe to drive";
            }
            else
            {
                return "This car can't start or turn off so it is not safe to drive";
            }
        }
    }
}
