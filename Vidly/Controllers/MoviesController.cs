using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movies = new Movie{ Name = "Shrek"};
            return View(movies);
        }
    }
}