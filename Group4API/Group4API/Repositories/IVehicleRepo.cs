//Made by Haseeb

using Group4API.Models;

namespace Group4API.Repositories
{
    public interface IVehicleRepo
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle GetVehicleById(int Id);
        Vehicle AddVehicle(Vehicle vehicle);
        void DeleteVehicle(int Id);
    }
}
