using Microsoft.AspNetCore.Mvc;

namespace Capstone_Project.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
