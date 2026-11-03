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
                    Title = "Real-Time Chat Application",
                    Description = "A web application providing real-time messaging where users can join anonymous chat rooms by selecting an avatar. Built with SignalR infrastructure to ensure seamless real-time communication.",
                    TechStack = ".NET Core 3.1, SignalR, Bootstrap, MVC",
                    ImageUrl = "/images/project/project1.png"
                },
                new Project
                {
                    Id = 2,
                    Title = "E-Commerce Platform",
                    Description = "A B2C e-commerce platform focused on clothing and accessories, featuring a modern UI. Developed with secure payment gateway integration and category-based product filtering.",
                    TechStack = ".NET MVC, Web API, MsSQL, NoSQL, Clean Architecture",
                    ImageUrl = "/images/project/project2.png"
                },
                new Project
                {
                    Id = 3,
                    Title = "Food Recipe & Event Application",
                    Description = "A mobile application allowing users to discover and share food recipes and events. Developed natively in Android Studio using Java.",
                    TechStack = "Java, Android Studio",
                    ImageUrl = "/images/project/project3.png"
                },
                new Project
                {
                    Id = 4,
                    Title = "Taboo-Style Party Game",
                    Description = "A time-constrained mobile party game where players describe a target keyword to their team without using the listed forbidden clue words. Developed natively to handle rapid state management and timer events.",
                    TechStack = "Java, Android SDK, XML",
                    ImageUrl = "/images/project/project4.png"
                },
                new Project
                {
                    Id = 5,
                    Title = "Digital Music Distribution Platform",
                    Description = "A corporate showcase and B2B communication platform providing digital music distribution and licensing services for independent artists.",
                    TechStack = ".NET MVC, Bootstrap, B2B Integration",
                    ImageUrl = "/images/project/project5.png"
                },
                new Project
                {
                    Id = 6,
                    Title = "AI Chat Assistant Application",
                    Description = "A mobile application featuring an intelligent chat assistant. Users can manage conversation histories and receive smart recommendations.",
                    TechStack = "Flutter, Dart, API and AI Integration",
                    ImageUrl = "/images/project/project6.png"
                },
                new Project
                {
                    Id = 7,
                    Title = "NFT Marketplace Platform",
                    Description = "A modern marketplace demo web application featuring a wallet connection concept, allowing users to discover digital artwork. Developed using the .NET Core 3.1 framework with MVC architecture.",
                    TechStack = ".NET Core 3.1, MVC, Bootstrap, HTML/CSS",
                    ImageUrl = "/images/project/project7.png"
                },
                new Project
                {
                    Id = 8,
                    Title = "Logistics Management Application",
                    Description = "A comprehensive cross-platform cargo management mobile application developed for logistics personnel, digitizing field operations such as goods receipt, barcode scanning, bagging, and manifest management.",
                    TechStack = "Flutter, Dart, .NET 5 (API), Python (Django) API",
                    ImageUrl = "/images/project/project8.png"
                },
                new Project
                {
                    Id = 9,
                    Title = "Stock Market & Portfolio Application",
                    Description = "A secure financial mobile portfolio management app developed for brokerage firms, enabling users to monitor live market data and execute stock and fund trades.",
                    TechStack = "Flutter, .NET API, WebSockets",
                    ImageUrl = "/images/project/project9.png"
                },
                new Project
                {
                    Id = 10,
                    Title = "Mobile Applications General Overview",
                    Description = "A unified presentation showcasing the UI/UX design and core interfaces of both the logistics and stock market mobile applications side-by-side.",
                    TechStack = "Flutter, Dart, Cross-Platform UI",
                    ImageUrl = "/images/project/project10.png"
                },
                new Project
                {
                    Id = 11,
                    Title = "Corporate Textile Web Application",
                    Description = "A corporate web project developed for the textile industry, showcasing the company's production capacity, and product catalogs.",
                    TechStack = ".NET MVC, HTML, CSS, JavaScript",
                    ImageUrl = "/images/project/project11.png"
                }
            );
        }
    }
}