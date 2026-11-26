//Made by Haseeb

using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories
{
    public class VehicleRepo : IVehicleRepo
    {
        private readonly JobManagementDbContext _context;
        public VehicleRepo(JobManagementDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles;
        }
        public Vehicle GetVehicleById(int Id)
        {
            if (Id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id value cannot be less than or equal to zero.\n");
            }

            var vehicleById = _context.Vehicles.FirstOrDefault(v => v.VehicleId == Id);

            if (vehicleById == null)
            {
                throw new ArgumentNullException("Vehicle By id is not found.\n");
            }

            return vehicleById;
        }
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("Vehicle information is invalid.\n");
            }
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return vehicle;
        }
        public void DeleteVehicle(int Id)
        {
            var getVehicleById = GetVehicleById(Id);

            if (getVehicleById == null)
            {
                throw new ArgumentNullException("Vehicle id is not found.\n");
            }
            _context.Vehicles.Remove(getVehicleById);
            _context.SaveChanges();
        }
    }
}
