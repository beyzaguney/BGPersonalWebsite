using Microsoft.AspNetCore.Mvc;

namespace BGPersonalWebsite.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
