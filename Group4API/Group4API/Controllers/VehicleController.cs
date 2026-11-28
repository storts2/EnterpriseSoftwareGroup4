// Made By Haseeb
using Microsoft.AspNetCore.Mvc;
using Group4API.Models;
using Group4API.Repositories;

namespace Group4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepo _vehicleRepo;

        public VehicleController(IVehicleRepo vehicleRepo)
        {
            _vehicleRepo = vehicleRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> GetAll()
        {
            return Ok(_vehicleRepo.GetAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<Vehicle> GetVehicleById(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest(new
                {
                    message = "Invalid Id information provided.\n"
                });
            }

            try
            {
                var vehicleById = _vehicleRepo.GetVehicleById(Id);
                return Ok(vehicleById);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new
                {
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        public ActionResult AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest(new
                {
                    message = "Invalid vehicle information provided."
                });
            }

            _vehicleRepo.AddVehicle(vehicle);
            return CreatedAtAction(nameof(GetVehicleById), new { Id = vehicle.VehicleId }, vehicle);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteVehicle(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest(new
                {
                    message = "Invalid id information provided."
                });
            }

            try
            {
                _vehicleRepo.DeleteVehicle(Id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new
                {
                    message = ex.Message
                });
            }
        }
    }
}