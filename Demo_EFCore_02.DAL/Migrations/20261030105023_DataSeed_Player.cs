using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo_EFCore_02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed_Player : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "First_Name", "last_Name", "Pseudo" },
                values: new object[,]
                {
                    { 1, "Della", "Duck", "MoonDuck" },
                    { 2, "Balthazar", "Picsou", null },
                    { 3, "Zaza", "Vanderquack", "TacticalPancake" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
