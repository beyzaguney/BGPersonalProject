using Microsoft.AspNetCore.Mvc;

namespace BGPersonalProject.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
