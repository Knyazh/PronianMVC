using Microsoft.AspNetCore.Mvc;

namespace ProniaMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

}
