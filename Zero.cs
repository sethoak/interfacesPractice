using System;

namespace CSharp_Interface
{
    public class Zero : IVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }
        public void ChargeBattery()
        {
            throw new System.NotImplementedException();
        }
        public void Drive()
        {
            Console.WriteLine("Whoosh");
        }
    }
}