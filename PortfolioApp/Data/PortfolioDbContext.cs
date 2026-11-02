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
                    Title = "Dancing Chat App",
                    Description = "A web application providing real-time messaging where users can join anonymous chat rooms by selecting an avatar. Built with SignalR infrastructure to ensure seamless real-time communication.",
                    TechStack = ".NET 8, SignalR, Bootstrap, MVC",
                    ImageUrl = "/images/project/project1.png"
                },
                new Project
                {
                    Id = 2,
                    Title = "E-Commerce",
                    Description = "A B2C e-commerce platform focused on clothing and accessories, featuring a modern UI. Developed with secure payment gateway integration (Iyzico) and category-based product filtering.",
                    TechStack = ".NET 8, Web API, SQLite, Clean Architecture",
                    ImageUrl = "/images/project/project2.png"
                },
                new Project
                {
                    Id = 3,
                    Title = "Food Sharing App",
                    Description = "A mobile application allowing users to discover and share food recipes and events. Developed natively in Android Studio using Java.",
                    TechStack = "Java, Android Studio",
                    ImageUrl = "/images/project/project3.png"
                },
                new Project
                {
                    Id = 4,
                    Title = "Basic Word Game App",
                    Description = "A time-constrained mobile educational puzzle game where users guess words based on visual clues. Developed as a cross-platform app using Flutter, featuring a simple and user-friendly interface.",
                    TechStack = "Flutter, Dart, Mobile UI",
                    ImageUrl = "/images/project/project4.png"
                },
                new Project
                {
                    Id = 5,
                    Title = "Logistics App",
                    Description = "A comprehensive cross-platform cargo management mobile application developed using Flutter for logistics personnel, digitizing field operations such as goods receipt, barcode scanning, bagging, and manifest management.",
                    TechStack = "Flutter, Dart, .NET 5, Python (Django) API",
                    ImageUrl = "/images/project/project5.png"
                },
                new Project
                {
                    Id = 6,
                    Title = "Stock Market App",
                    Description = "A secure financial mobile portfolio management app developed for brokerage firms, enabling users to monitor live market data and execute stock and fund trades.",
                    TechStack = "Flutter, .NET API, Node.js, WebSockets",
                    ImageUrl = "/images/project/project6.png"
                },
                new Project
                {
                    Id = 7,
                    Title = "NFT Market Demo",
                    Description = "A modern marketplace demo web application featuring a wallet connection concept, allowing users to discover digital artwork (NFTs). Developed using the .NET Core 3.1 framework with MVC architecture.",
                    TechStack = ".NET Core 3.1, MVC, Bootstrap, HTML/CSS",
                    ImageUrl = "/images/project/project7.png"
                },
                new Project
                {
                    Id = 8,
                    Title = "Music Delly Distribution Platform",
                    Description = "A corporate showcase and B2B communication platform providing digital music distribution and licensing services for independent artists.",
                    TechStack = ".NET MVC, Bootstrap, B2B Integration",
                    ImageUrl = "/images/project/project8.png"
                },
                new Project
                {
                    Id = 9,
                    Title = "Textile Corporate Web App",
                    Description = "A multilingual corporate web project developed for the textile industry, showcasing the company's production capacity, R&D initiatives, and product catalogs.",
                    TechStack = ".NET MVC, HTML, CSS, JavaScript",
                    ImageUrl = "/images/project/project9.png"
                }
            );
        }
    }
}