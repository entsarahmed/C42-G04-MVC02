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

        [HttpGet] //Get: baseUrl/Home/AboutUs

        public IActionResult AboutUs()//Action Move Master Page or Home Controller
        {

            return View();



        }
        [HttpGet] //Get: baseUrl/Home/Privacy
        public IActionResult Privacy()//Action Move Master Page or Home Controller
        {

            return View();



        }
        [HttpGet] //Get: baseUrl/Home/ContactUs
        public IActionResult ContactUs()//Action Move Master Page or Home Controller
        {

            return View();



        }
    }
}
