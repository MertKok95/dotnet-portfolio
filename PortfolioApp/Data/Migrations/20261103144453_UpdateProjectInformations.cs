using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectInformations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "TechStack",
                value: ".NET Core 3.1, SignalR, Bootstrap, MVC");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "TechStack",
                value: ".NET MVC, Web API, MsSQL, NoSQL, Clean Architecture");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "TechStack", "Title" },
                values: new object[] { "A time-constrained mobile party game where players describe a target keyword to their team without using the listed forbidden clue words. Developed natively to handle rapid state management and timer events.", "/images/project/project4.jpg", "Java, Android SDK, XML", "Taboo-Style Party Game" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "A mobile application featuring an intelligent chat assistant. Users can manage conversation histories and receive smart recommendations.", "Flutter, Dart, API and AI Integration" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "TechStack",
                value: "Flutter, Dart, .NET 5 (API), Python (Django) API");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                column: "TechStack",
                value: "Flutter, .NET API, WebSockets");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "A corporate web project developed for the textile industry, showcasing the company's production capacity, and product catalogs.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "TechStack",
                value: ".NET 8, SignalR, Bootstrap, MVC");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "TechStack",
                value: ".NET 8, Web API, SQLite, Clean Architecture");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "TechStack", "Title" },
                values: new object[] { "A time-constrained mobile educational puzzle game where users guess words based on visual clues. Developed as a cross-platform app using Flutter, featuring a simple and user-friendly interface.", "/images/project/project4.png", "Flutter, Dart, Mobile UI", "Educational Puzzle Game" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "A mobile application featuring an intelligent chat assistant capable of natural language processing. Users can manage conversation histories and receive smart recommendations.", "Flutter, Dart, AI Integration" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                column: "TechStack",
                value: "Flutter, Dart, .NET 5, Python (Django) API");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                column: "TechStack",
                value: "Flutter, .NET API, Node.js, WebSockets");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "A multilingual corporate web project developed for the textile industry, showcasing the company's production capacity, R&D initiatives, and product catalogs.");
        }
    }
}
