using Microsoft.AspNetCore.Mvc;

public class CinemaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(int? id, string name, string address, bool hasProjector, bool isOpen, string contactEmail)
    {
        if (id.HasValue)
        {
            ViewBag.Id = id.Value;
            ViewBag.Name = name;
            ViewBag.Address = address;
            ViewBag.HasProjector = hasProjector;
            ViewBag.IsOpen = isOpen;
            ViewBag.ContactEmail = contactEmail;
            return View("DisplayData");
        }
        return RedirectToAction("Index");
    }
}
