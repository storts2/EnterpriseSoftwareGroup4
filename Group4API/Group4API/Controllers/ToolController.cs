// Made by Haseeb

using Group4API.Models;
using Group4API.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace Group4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolController : ControllerBase
    {
        private readonly IToolRepo _toolRepo;

        public ToolController(IToolRepo toolRepo)
        {
            _toolRepo = toolRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tools>> GetTools()
        {
            return Ok(_toolRepo.GetAllTools());
        }

        [HttpGet("{Id}")]
        public ActionResult<Tools> GetToolById(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest(new
                {
                    message = "Id cannot be less than or equal to zero.\n"
                });
            }

            try
            {
                var toolById = _toolRepo.GetToolById(Id);
                return Ok(toolById);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(new
                {
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        public ActionResult AddTool(Tools tool)
        {
            if (tool == null)
            {
                return BadRequest(new
                {
                    message = "Invalid tool information given.\n"
                });
            }

            var addTool = _toolRepo.AddTool(tool);
            return CreatedAtAction(nameof(GetToolById), new { Id = addTool.ToolId }, addTool);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteTool(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest(new
                {
                    message = "Invalid id value provided.\n"
                });
            }

            try
            {
                _toolRepo.DeleteTool(Id);
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