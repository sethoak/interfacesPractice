using System;

namespace CSharp_Interface
{
    public class Ram : IVehicle, IGasVehicle
    {
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