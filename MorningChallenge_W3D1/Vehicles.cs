using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_W3D1
{
    public enum VehicleType { Sedan, SUV, Motorcycle, Truck, MiniVan, Other }
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }
        VehicleType TypeOfVehicle { get; }

        bool CanStart { get; }
        bool CanTurnOff { get; }
        string CanDrive();
    }
}
