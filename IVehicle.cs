namespace CSharp_Interface
{
    public interface IVehicle
    {
        void Drive();
    }
}

/* Differences
1) No specified accessibility on props or methods (no public/private Drive).
2) We use the 'interface' keyword instead of 'class'.
3) No implementation (ex of the method Drive()).

*/