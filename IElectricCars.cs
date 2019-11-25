namespace CSharp_Interface
{
    public interface IElectricVehicle
    {
        int BatterykWh { get; set; }
        void ChargeBattery();
    }
}