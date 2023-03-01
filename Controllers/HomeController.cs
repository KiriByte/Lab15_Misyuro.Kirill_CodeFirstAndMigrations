using System.Diagnostics;
using Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Context;
using Microsoft.AspNetCore.Mvc;
using Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DbContextOptions<MyDbContext> _context;

    public HomeController(ILogger<HomeController> logger,DbContextOptions<MyDbContext> context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
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