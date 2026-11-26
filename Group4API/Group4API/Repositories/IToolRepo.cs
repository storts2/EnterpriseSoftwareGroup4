//Made by Haseeb
using Group4API.Models;

namespace Group4API.Repositories
{
    public interface IToolRepo
    {
        IEnumerable<Tools> GetAllTools();
        Tools GetToolById(int Id);
        Tools AddTool(Tools tool);
        void DeleteTool(int Id);
    }
}
