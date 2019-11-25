using System;

namespace CSharp_Interface
{
    public class Cessna : IVehicle, IGasVehicle
    {
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