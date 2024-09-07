using Microsoft.AspNetCore.Mvc;
using Project_Structure.Models;

namespace Project_Structure.Controllers
{
    public class MoviesController:Controller
    {
        [FromServices]
        public IConfiguration Configuration { get; }

        //public MoviesController(IConfiguration configuration)
        //{
           
        //    Configuration = configuration;
        //}


        #region set Data from appSetting
        //private readonly IConfiguration _configuration;
        //public MoviesController(IConfiguration configuration) // ASK CLR for Creating Object from Class Implementing the Interface "IConfiguration
        //{
        //    _configuration = configuration;
        //} 
        #endregion

        #region Route
        //Action: Public Non-Static Object Member Method inside the Controller
        [ActionName("Index")]
        [HttpGet] // Get: baseUrl/Movies/GetMovie/{id}?name=avatar
        public string GetAllMovie()
        {
            return "All Movies";
        }






        //public string GetMovie (int code)
        //{
        //    return $"Movie With Code: {code}";//0
        //}

        //  UrlPath//Movies/GetMovie/10?name=Avatar



        //  [Authorize(Roles ="VIP")]
        //public string GetMovie(int id, string name)
        //{
        //  return $"Movie with Name {name} and Movie With Id: {id}";
        //}


        ////[AcceptVerbs("Get","Post")]
        ////[HttpGet]
        ////public ViewResult CreateMovie()
        ////{
        ////    return new ViewResult();
        ////}

        ////[ActionName("ConfirmCreateMovie")]
        ////[HttpPost]
        ////public OkResult CreateMovie( Movie Model)
        ////{
        ////    return new OkResult();
        ////}
        ///

        //public string GetMovie(int id)
        //{
        //    return $"Movie With Id: {id}";
        //} 
        #endregion







        #region Action ReturnTypes
        //public IActionResult GetMovie(int id) 
        //{
        //    if (id == 0)
        //        // return new BadRequestResult();
        //        return BadRequest();


        //    if (id == 100)
        //        //return new NotFoundResult();
        //        return NotFound();


        //   //ContentResult result = new ContentResult();
        //   // result.Content = $"<h1>Movie with Id: {id}<h1>";
        //   //// result.ContentType="object/pdf";

        //   //     result.ContentType = "text/html";
        //   //     // result.StatusCode=200;

        //   // return result;


        //    return Content($"<h1>Movie with Id: {id}<h1>", "text/html");



        //}

        //[HttpGet] // Get: baseUrl/Movies/Hamada
        //public IActionResult Hamada()
        //{
        //    // RedirectResult result = new RedirectResult("https://wuzzuf.net/jobs/egypt");
        //    // RedirectResult result = new RedirectResult(_configuration["WuzzufUrl"] ?? string.Empty);

        //    //RedirectResult result = new RedirectResult("https://localhost:5095/Movies/GetMovie/10");
        //    //RedirectResult result = new RedirectResult($"{_configuration["BaseUrl"]}Movies/GetMovie/10");
        //    // return result;



        //    // return Redirect("https://wuzzuf.net/jobs/egypt");
        //    // return Redirect(_configuration["WuzzufUrl"] ?? string.Empty);

        //    //return RedirectToAction(nameof(GetMovie), "Movies", new { id = 10 });


        //    //RedirectToActionResult result = new RedirectToActionResult(nameof(GetMovie), "Movies",new {id=10});
        //    // return result;

        //    //RedirectToRouteResult result = new RedirectToRouteResult("default",null);

        //    //return result;
        //    //return RedirectToRoute("default",null);

        //} 
        #endregion


        //Model Value Providers
        //1. Form-Data => Input
        //2. Route Data => pass as Segment : baseUrl/Movies/GetMovie/10
        //3.  Query String => Query Param : baseUrl/Movies/GetMovie?id=10
        //4. Request Header => Header
        //5. Request Body  =>         public IActionResult GetMovie(/*[FromHeader]*/int id, [FromBody] Movie movie)
        //6. From Service


        [HttpGet] //GET: baseUrl/Movies/GetMovie/10
        public IActionResult GetMovie(/*[FromHeader]*/int id, [FromBody] Movie movie)
        {
            if (id == 0)
                // return new BadRequestResult();
                return BadRequest();


            if (id == 100)
                //return new NotFoundResult();
                return NotFound();
            return Content($"<h1>Movie with Id: {id}<h1>", "text/html");

        }

        [HttpGet]
        public IActionResult CreateMovie([FromServices] IConfiguration configuration)
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            //Create Movie
            return Ok(movie);

        }
        


    }
}
