using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/project/project4.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/project/project4.jpg");
        }
    }
}
