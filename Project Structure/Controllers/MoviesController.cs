using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.Controllers
{
    public class MoviesController:Controller
    {

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

        public string GetMovie(int id)
        {
            return $"Movie With Id: {id}";
        }

    }
}
