namespace CSharp_Interface
{
    public class Prius : IVehicle, IGasVehicle, IElectricVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }
        public int BatterykWh { get; set; }

        public void ChargeBattery()
        {
            throw new System.NotImplementedException();
        }

        public void Drive()
        {
            throw new System.NotImplementedException();
        }

        public void RefuelTank()
        {
            throw new System.NotImplementedException();
        }
    }
}