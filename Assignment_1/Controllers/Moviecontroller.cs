using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class Moviecontroller : Controller
    {
        //public string GetMovies(int id)
        //{
        //    return $"Movie with id = {id}";
        //}

        ////public ContentResult MovieCast(string name)
        ////{
        ////    ContentResult content = new ContentResult();
        ////    content.Content = $"Movie cast with name = {name}";
        ////    content.ContentType = "text/html";
        ////    return content;
        ////}

        //public IActionResult Index(int id)
        //{
        //    if (id == 0)
        //        return BadRequest();

        //    else if (id < 10)
        //        return NotFound();

        //    else
        //        return Content("Movie with id = " + id);
        //}

        //public IActionResult TestRedirectAction()
        //{
        //    return RedirectToAction(nameof(GetMovies),/*nameof(Moviecontroller)*/ "Movies", 10);
        //}

        //public IActionResult TestModelBinding([FromQuery]int id, string name)
        //{
        //    return Content($"id = {id}, name = {name}");
        //}

        //public IActionResult AddMovie([FromBody]Movies movies)
        //{
        //    if (movies is null)
        //        return BadRequest();
        //    else
        //        return Content($"Movie with id = {movies.Id} and name = {movies.Name} is added");
        //}
    }
}
