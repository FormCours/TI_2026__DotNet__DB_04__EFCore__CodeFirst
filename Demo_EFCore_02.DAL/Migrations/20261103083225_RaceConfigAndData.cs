using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo_EFCore_02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RaceConfigAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Humain" },
                    { 2, "Canard" },
                    { 3, "Elfe" },
                    { 4, "Panda" },
                    { 5, "Nain" },
                    { 6, "Halfelin" },
                    { 7, "Gnome" },
                    { 8, "Demi-Orque" },
                    { 9, "Tieffelin" },
                    { 10, "Drakéide" },
                    { 11, "Aasimar" },
                    { 12, "Goliath" },
                    { 13, "Githyanki" },
                    { 14, "Githzerai" },
                    { 15, "Forgelinger" },
                    { 16, "Félys" },
                    { 17, "Genasi" },
                    { 18, "Kenku" },
                    { 19, "Tabaxi" },
                    { 20, "Lézardien" },
                    { 21, "Firbolg" },
                    { 22, "Wookiee" },
                    { 23, "Twi'lek" },
                    { 24, "Zabrak" },
                    { 25, "Rodien" },
                    { 26, "Trandoshan" },
                    { 27, "Mon Calamari" },
                    { 28, "Bothan" },
                    { 29, "Chiss" },
                    { 30, "Togruta" },
                    { 31, "Kel Dor" },
                    { 32, "Sullustéen" },
                    { 33, "Ithorien" },
                    { 34, "Jawa" },
                    { 35, "Ewok" },
                    { 36, "Gamorréen" },
                    { 37, "Geonosien" },
                    { 38, "Kaminoen" },
                    { 39, "Mirialan" },
                    { 40, "Nautolan" },
                    { 41, "Pau'an" },
                    { 42, "Hobbit" },
                    { 43, "Uruk-hai" },
                    { 44, "Orque" },
                    { 45, "Gobelin" },
                    { 46, "Ent" },
                    { 47, "Semi-Elfe" },
                    { 48, "Dúnadan" },
                    { 49, "Puckel-Man" },
                    { 50, "Avari" },
                    { 51, "Beornide" },
                    { 52, "Humain Augmenté" },
                    { 53, "Exotique Biosculpté" },
                    { 54, "I.A. Libre" },
                    { 55, "Android / Répliquant" },
                    { 56, "Cyborg Full-Body" },
                    { 57, "Clone de Lignée" },
                    { 58, "Troll" },
                    { 59, "Néo-Dauphin Évolué" },
                    { 60, "Néo-Chimpanzé Évolué" },
                    { 61, "Génétique Muté" },
                    { 62, "Post-Humain Numérique" },
                    { 63, "Humain Isolé" },
                    { 64, "Goule des Décharges" },
                    { 65, "Transhumain Éco-conçu" },
                    { 66, "Drone de Conscience" },
                    { 67, "Broo" },
                    { 68, "Uz / Troll Sombre" },
                    { 69, "Mostali / Nain d'Argile" },
                    { 70, "Durulz" },
                    { 71, "Tcho-Tcho" },
                    { 72, "Profond / Deep One" },
                    { 73, "Goule de Lovecraft" },
                    { 74, "Mi-Go" },
                    { 75, "Insecte de Shaggai" },
                    { 76, "Morlock" },
                    { 77, "Éloi" },
                    { 78, "Automate à Vapeur" },
                    { 79, "Homunculus de Mercure" },
                    { 80, "Myconide Écorché" },
                    { 81, "Skaven" },
                    { 82, "Fimir" },
                    { 83, "Homme-Lézard de la jungle" },
                    { 84, "Zoat" },
                    { 85, "Méta-Baron Mutant" },
                    { 86, "Nephilim" },
                    { 87, "Sélénite" },
                    { 88, "Méduse Flottante" },
                    { 89, "Nuage Pensant" },
                    { 90, "Insectoïde Vespiforme" },
                    { 91, "Plante Carnivore Anthropomorphe" },
                    { 92, "Ombre Vivante" },
                    { 93, "Silico-Forme Cristallin" },
                    { 94, "Spectre d'Énergie Ectoplasmique" }
                });

            migrationBuilder.CreateIndex(
                name: "IDX_Races_Name",
                table: "Races",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
