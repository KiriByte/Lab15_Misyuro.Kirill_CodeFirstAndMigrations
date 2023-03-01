using Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Controllers;

public class DatabaseController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DbContextOptions<MyDbContext> _context;

    public DatabaseController(ILogger<HomeController> logger, DbContextOptions<MyDbContext> context)
    {
        _logger = logger;
        _context = context;
    }


    public IActionResult Index()
    {
        SortEmployesByFirstName();
        FindEmployesByFirstName("ren");
        CountEmployesByPosition();

        return View();
    }

    public void SortEmployesByFirstName()
    {
        using (var db = new MyDbContext(_context))
        {
            var x = db.Employee.OrderBy(s => s.FirstName);
        }
    }

    public void FindEmployesByFirstName(string name)
    {
        using (var db = new MyDbContext(_context))
        {
            var x = db.Employee.Where(employee => employee.FirstName.Contains(name));
        }
    }

    public void CountEmployesByPosition()
    {
        using (var db = new MyDbContext(_context))
        {
            var x = db.Position.GroupJoin(db.Employee,
                p => p.Id,
                e => e.PositionId,
                (p, e) => new
                {
                    p.PositionName, Count = e.Count()
                });
        }
    }
}