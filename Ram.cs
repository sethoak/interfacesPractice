using System;

namespace CSharp_Interface
{
    public class Ram : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("ROAR!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}