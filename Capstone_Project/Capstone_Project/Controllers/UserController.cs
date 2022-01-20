using Microsoft.AspNetCore.Mvc;

namespace Capstone_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
