using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Services; 

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

        public async Task<IActionResult> Projects()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return View(projects);
        }

        public async Task<IActionResult> Resume()
        {
            return View();
        }
    }
}