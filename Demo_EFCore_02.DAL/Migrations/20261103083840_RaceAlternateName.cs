using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFCore_02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RaceAlternateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateName",
                table: "Races",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AlternateName", "Name" },
                values: new object[] { "Répliquant", "Android" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AlternateName", "Name" },
                values: new object[] { "Troll Sombre", "Uz" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AlternateName", "Name" },
                values: new object[] { "Nain d'Argile", "Mostali" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AlternateName", "Name" },
                values: new object[] { "Deep One", "Profond" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateName",
                table: "Races");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Android / Répliquant");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Uz / Troll Sombre");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Mostali / Nain d'Argile");

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "Profond / Deep One");
        }
    }
}
