using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //GET: baseUrl/Home/Index
        public IActionResult Index()//Action Move Master Page or Home Controller
        {
            return View();
        }
    }
}
