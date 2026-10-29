using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Services; // Bu satırı ekle

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectService _projectService;

        // Servisi constructor (yapıcı metot) ile içeri alıyoruz
        public HomeController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        // Projects action'ını asenkron yapıp verileri View'a gönderiyoruz
        public async Task<IActionResult> Projects()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}