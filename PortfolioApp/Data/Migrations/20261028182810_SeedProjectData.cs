using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedProjectData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GitHubUrl", "ImageUrl", "ProjectUrl", "TechStack", "Title" },
                values: new object[,]
                {
                    { 1, "Büyük ölçekli e-ticaret sistemleri için geliştirilmiş, yüksek performanslı RESTful API mimarisi.", "https://github.com/mertkok", null, null, ".NET 8, Web API, SQLite, Clean Architecture", "E-Commerce API" },
                    { 2, "SignalR kullanılarak geliştirilmiş, anlık veri akışı ve grafik güncellemeleri sunan web uygulaması.", "https://github.com/mertkok", null, null, ".NET 8, SignalR, Bootstrap 5, MVC", "Real-Time Dashboard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
