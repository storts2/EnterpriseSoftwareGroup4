using Microsoft.AspNetCore.Mvc;

namespace Group4API.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
