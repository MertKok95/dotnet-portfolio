using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StructuredContentAndProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Real-Time Chat Application");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A B2C e-commerce platform focused on clothing and accessories, featuring a modern UI. Developed with secure payment gateway integration and category-based product filtering.", "E-Commerce Platform" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Food Recipe & Event Application");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Educational Puzzle Game");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A corporate showcase and B2B communication platform providing digital music distribution and licensing services for independent artists.", ".NET MVC, Bootstrap, B2B Integration", "Digital Music Distribution Platform" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A mobile application featuring an intelligent chat assistant capable of natural language processing. Users can manage conversation histories and receive smart recommendations.", "Flutter, Dart, AI Integration", "AI Chat Assistant Application" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A modern marketplace demo web application featuring a wallet connection concept, allowing users to discover digital artwork. Developed using the .NET Core 3.1 framework with MVC architecture.", "NFT Marketplace Platform" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A comprehensive cross-platform cargo management mobile application developed for logistics personnel, digitizing field operations such as goods receipt, barcode scanning, bagging, and manifest management.", "Flutter, Dart, .NET 5, Python (Django) API", "Logistics Management Application" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A secure financial mobile portfolio management app developed for brokerage firms, enabling users to monitor live market data and execute stock and fund trades.", "Flutter, .NET API, Node.js, WebSockets", "Stock Market & Portfolio Application" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GitHubUrl", "ImageUrl", "ProjectUrl", "TechStack", "Title" },
                values: new object[,]
                {
                    { 10, "A unified presentation showcasing the UI/UX design and core interfaces of both the logistics and stock market mobile applications side-by-side.", null, "/images/project/project10.png", null, "Flutter, Dart, Cross-Platform UI", "Mobile Applications General Overview" },
                    { 11, "A multilingual corporate web project developed for the textile industry, showcasing the company's production capacity, R&D initiatives, and product catalogs.", null, "/images/project/project11.png", null, ".NET MVC, HTML, CSS, JavaScript", "Corporate Textile Web Application" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Dancing Chat App");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A B2C e-commerce platform focused on clothing and accessories, featuring a modern UI. Developed with secure payment gateway integration (Iyzico) and category-based product filtering.", "E-Commerce" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Food Sharing App");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Basic Word Game App");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A comprehensive cross-platform cargo management mobile application developed using Flutter for logistics personnel, digitizing field operations such as goods receipt, barcode scanning, bagging, and manifest management.", "Flutter, Dart, .NET 5, Python (Django) API", "Logistics App" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A secure financial mobile portfolio management app developed for brokerage firms, enabling users to monitor live market data and execute stock and fund trades.", "Flutter, .NET API, Node.js, WebSockets", "Stock Market App" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A modern marketplace demo web application featuring a wallet connection concept, allowing users to discover digital artwork (NFTs). Developed using the .NET Core 3.1 framework with MVC architecture.", "NFT Market Demo" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A corporate showcase and B2B communication platform providing digital music distribution and licensing services for independent artists.", ".NET MVC, Bootstrap, B2B Integration", "Music Delly Distribution Platform" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "TechStack", "Title" },
                values: new object[] { "A multilingual corporate web project developed for the textile industry, showcasing the company's production capacity, R&D initiatives, and product catalogs.", ".NET MVC, HTML, CSS, JavaScript", "Textile Corporate Web App" });
        }
    }
}
