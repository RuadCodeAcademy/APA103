using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _27_FrontToBackSqlConnection.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Sliders",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Products",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "ProductImages",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Categories",
                newName: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Sliders",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Products",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "ProductImages",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Categories",
                newName: "isDeleted");
        }
    }
}
