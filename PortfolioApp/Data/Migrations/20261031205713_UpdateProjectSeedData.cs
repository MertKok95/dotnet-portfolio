using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A web application providing real-time messaging where users can join anonymous chat rooms by selecting an avatar. Built with SignalR infrastructure to ensure seamless real-time communication.", ".NET 8, SignalR, Bootstrap, MVC", "Dancing Chat App" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A B2C e-commerce platform focused on clothing and accessories, featuring a modern UI. Developed with secure payment gateway integration (Iyzico) and category-based product filtering.", ".NET 8, Web API, SQLite, Clean Architecture", "E-Commerce" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GitHubUrl", "ImageUrl", "ProjectUrl", "TechStack", "Title" },
                values: new object[,]
                {
                    { 3, "A mobile application allowing users to discover and share food recipes and events. Developed natively in Android Studio using Java.", null, "/images/project/project3.png", null, "Java, Android Studio", "Food Sharing App" },
                    { 4, "A time-constrained mobile educational puzzle game where users guess words based on visual clues. Developed as a cross-platform app using Flutter, featuring a simple and user-friendly interface.", null, "/images/project/project4.png", null, "Flutter, Dart, Mobile UI", "Basic Word Game App" },
                    { 5, "A comprehensive cross-platform cargo management mobile application developed using Flutter for logistics personnel, digitizing field operations such as goods receipt, barcode scanning, bagging, and manifest management.", null, "/images/project/project5.png", null, "Flutter, Dart, .NET 5, Python (Django) API", "Logistics App" },
                    { 6, "A secure financial mobile portfolio management app developed for brokerage firms, enabling users to monitor live market data and execute stock and fund trades.", null, "/images/project/project6.png", null, "Flutter, .NET API, Node.js, WebSockets", "Stock Market App" },
                    { 7, "A modern marketplace demo web application featuring a wallet connection concept, allowing users to discover digital artwork (NFTs). Developed using the .NET Core 3.1 framework with MVC architecture.", null, "/images/project/project7.png", null, ".NET Core 3.1, MVC, Bootstrap, HTML/CSS", "NFT Market Demo" },
                    { 8, "A corporate showcase and B2B communication platform providing digital music distribution and licensing services for independent artists.", null, "/images/project/project8.png", null, ".NET MVC, Bootstrap, B2B Integration", "Music Delly Distribution Platform" },
                    { 9, "A multilingual corporate web project developed for the textile industry, showcasing the company's production capacity, R&D initiatives, and product catalogs.", null, "/images/project/project9.png", null, ".NET MVC, HTML, CSS, JavaScript", "Textile Corporate Web App" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "Büyük ölçekli e-ticaret sistemleri için geliştirilmiş, yüksek performanslı RESTful API mimarisi.", ".NET 8, Web API, SQLite, Clean Architecture", "E-Commerce API" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "SignalR kullanılarak geliştirilmiş, anlık veri akışı ve grafik güncellemeleri sunan web uygulaması.", ".NET 8, SignalR, Bootstrap 5, MVC", "Real-Time Dashboard" });
        }
    }
}
