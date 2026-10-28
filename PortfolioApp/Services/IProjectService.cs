using PortfolioApp.Models;

namespace PortfolioApp.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllProjectsAsync();
    }
}