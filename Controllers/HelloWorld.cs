using Microsoft.AspNetCore.Mvc;

    
namespace stunning_robot_HR.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}