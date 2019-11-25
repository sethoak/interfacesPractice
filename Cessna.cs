using System;

namespace CSharp_Interface
{
    public class Cessna : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("SOAR!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}