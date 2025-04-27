using Microsoft.AspNetCore.Mvc;
using tp_laba2.Models;

namespace tp_laba2.Controllers
{
    public class FilmStudioController : Controller
    {
        private static List<FilmStudio> studios = new List<FilmStudio>();

        static FilmStudioController()
        {
            Helpers.FilmStudioHelpers.GetMockFilmStudioList()
                .ForEach(studios.Add);
        }


        public ActionResult Index()
        {
            TempData["UseInternalMethod"] = true;
            return View(studios);
        }


        public IActionResult Details(int id)
        {
            var studio = studios.Find(s => s.Id == id);
            if (studio == null)
            {
                return NotFound();
            }
            return View(studio);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FilmStudio studio)
        {
            if (ModelState.IsValid)
            {
                studio.Id = studios.Count + 1; // Присваиваем ID на основе количества в списке
                studios.Add(studio);
                return RedirectToAction("Index");
            }
            return View(studio);
        }


        public IActionResult Edit(int id)
        {
            var studio = studios.FirstOrDefault(s => s.Id == id);
            if (studio == null)
            {
                return NotFound();
            }
            return View(studio);
        }


        [HttpPost]
        public IActionResult Edit(FilmStudio studio)
        {
            if (ModelState.IsValid)
            {
                var existingStudio = studios.FirstOrDefault(s => s.Id == studio.Id);
                if (existingStudio != null)
                {
                    existingStudio.Name = studio.Name;
                    existingStudio.EstablishedYear = studio.EstablishedYear;
                    existingStudio.Country = studio.Country;
                    existingStudio.Phone = studio.Phone;
                    existingStudio.FilmCount = studio.FilmCount;
                    existingStudio.Description = studio.Description;
                }
                return RedirectToAction("Index");
            }
            return View(studio);
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
