using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class FilmController : Controller
    {
        FilmContext db;
        public FilmController(FilmContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Film> films = await Task.Run(() => db.Films);
            return View(films);
        }


    }
}