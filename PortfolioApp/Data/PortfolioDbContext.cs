using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models;

namespace PortfolioApp.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(
                new Project 
                { 
                    Id = 1, 
                    Title = "E-Commerce API", 
                    Description = "Büyük ölçekli e-ticaret sistemleri için geliştirilmiş, yüksek performanslı RESTful API mimarisi.", 
                    TechStack = ".NET 8, Web API, SQLite, Clean Architecture",
                    ImageUrl = "/images/project/project1.png" 
                },
                new Project 
                { 
                    Id = 2, 
                    Title = "Real-Time Dashboard", 
                    Description = "SignalR kullanılarak geliştirilmiş, anlık veri akışı ve grafik güncellemeleri sunan web uygulaması.", 
                    TechStack = ".NET 8, SignalR, Bootstrap 5, MVC",
                    ImageUrl = "/images/project/project2.png" 
                }
            );
        }
    }
}