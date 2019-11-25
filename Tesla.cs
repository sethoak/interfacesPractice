using System;

namespace CSharp_Interface
{

    //setting Tesla as a Child to IVehicle
    public class Tesla : IVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }
        public void ChargeBattery()
        {
            BatterykWh = 100;
        }
        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
}