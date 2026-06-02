using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCapplication.Models;

namespace MVCapplication.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Landing");
    }

    public IActionResult Landing()
    {
        return View();
    }

    public IActionResult Account()
    {
        return View();
    }

    public IActionResult LearnerPortal()
    {
        return View();
    }

    public IActionResult Booking()
    {
        return View();
    }

    public IActionResult Contract()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
