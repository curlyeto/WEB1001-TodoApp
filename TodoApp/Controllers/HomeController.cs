using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //Define our context class globally.
    TodoDbContext _todoDbContext;
    // To access  Context class, give parameter HomeController construstor in our context class.
    public HomeController(ILogger<HomeController> logger,TodoDbContext todoDbContex)
    {
        _todoDbContext = todoDbContex;
        _logger = logger;
    }

    public IActionResult Index()

    {
        // Pull data from our todo table.
        // When pulling data, bring where and Iscompleted false.
        List<Todo> todos=_todoDbContext.Todo.Where(c => c.IsCompleted==false).ToList();
        // Send todos list to view
        ViewBag.Todos = todos;
        return View();
    }

    private TodoDbContext TodoDbContext()
    {
        throw new NotImplementedException();
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

