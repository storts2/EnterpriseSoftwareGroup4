//Made by Haseeb
using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories
{
    public class ToolRepo : IToolRepo
    {
        private readonly JobManagementDbContext _context;
        ToolRepo(JobManagementDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Tools> GetAllTools()
        {
            return _context.Tools;
        }
        public Tools GetToolById(int Id)
        {
            if (Id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id is invalid.\n");
            }
            
            var toolById = _context.Tools.FirstOrDefault(t => t.ToolId == Id);

            if (toolById == null)
            {
                throw new ArgumentNullException("Tool is not found.\n");
            }

            return toolById;
        }
        public Tools AddTool(Tools tool)
        {
            if (tool == null)
            {
                throw new ArgumentNullException("Tool information is invalid.\n");
            }

            _context.Tools.Add(tool);
            _context.SaveChanges();
            return tool;
        }
        public void DeleteTool(int Id)
        {
            var toolById = GetToolById(Id);
            if (toolById == null)
            {
                throw new ArgumentNullException("Tool is not found.\n");
            }

            _context.Tools.Remove(toolById);
            _context.SaveChanges();
        }
    }
}
