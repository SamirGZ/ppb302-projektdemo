using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ppb302_projektdemo.Models;

namespace ppb302_projektdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PraktiskaLivet()
    {
        return View();
    }

    public IActionResult Barnomsorg()
    {
        return View();
    }

    public IActionResult Boende()
    {
        return View();
    }

    public IActionResult Gemenskapen()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
