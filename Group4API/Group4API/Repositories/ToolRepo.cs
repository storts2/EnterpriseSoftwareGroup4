//Made by Haseeb
using Group4API.DataAccessLayer;
using Group4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Group4API.Repositories
{
    public class ToolRepo : IToolRepo
    {
        private readonly JobManagementDbContext _context;
        public ToolRepo(JobManagementDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<Tools> GetAllTools()
        {
            return _context.Tools
                .ToList();
        }
        public Tools GetToolById(int Id)
        {
            if (Id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Id),"Tool Id is invalid.\n");
            }
            
            var toolById = _context.Tools.FirstOrDefault(t => t.ToolId == Id);

            if (toolById == null)
            {
                throw new KeyNotFoundException($"Tool with Id {Id} is not found.\n");
            }

            return toolById;
        }
        public Tools AddTool(Tools tool)
        {
            if (tool == null)
            {
                throw new ArgumentNullException(nameof(tool), "Tool information is invalid.\n");
            }

            _context.Tools.Add(tool);
            _context.SaveChanges();
            return tool;
        }
        public void DeleteTool(int Id)
        {
            var toolById = GetToolById(Id);
            _context.Tools.Remove(toolById);
            _context.SaveChanges();
        }
    }
}
