using System;
using System.Collections.Generic;

namespace CSharp_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGasVehicle> gasFacility = new List<IGasVehicle>();
            List<IElectricVehicle> chargingFacility = new List<IElectricVehicle>();

            var myTesla = new Tesla();
            var myCessna = new Cessna();
            var myRam = new Ram();
            var myZero = new Zero();

            gasFacility.Add(myRam);
            gasFacility.Add(myCessna);

            chargingFacility.Add(myTesla);
            chargingFacility.Add(myZero);

        }
    }
}