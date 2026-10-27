using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Projects()
    {
        var myProjects = new List<ProjectItem>
        {
            new ProjectItem { Title = "Image Compressor", Description = "A Python script to optimize profile pictures for web.", Technologies = "Python, Pillow", GithubUrl = "https://github.com/KULLANICI_ADIN/image-compressor-python" },
            new ProjectItem { Title = "E-Commerce REST API", Description = "Backend service with JWT authentication and CRUD operations.", Technologies = "C#, ASP.NET Core, EF Core", GithubUrl = "#" }
        };
        return View(myProjects);
    }
}
