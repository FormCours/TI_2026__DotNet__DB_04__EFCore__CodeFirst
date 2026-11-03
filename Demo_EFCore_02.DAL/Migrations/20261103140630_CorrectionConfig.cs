using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo_EFCore_02.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Univers = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    RunnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Campaigns_Players_RunnerId",
                        column: x => x.RunnerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "date", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.CheckConstraint("CK_Characters_Level", "Level > 0");
                    table.ForeignKey(
                        name: "FK_Characters_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LevelMinimumForSpecialization = table.Column<int>(type: "int", nullable: true),
                    RequirementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpecializations", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_CharacterSpecializations_CharacterSpecializations_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "CharacterSpecializations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharacterParticipes",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false),
                    IsNPC = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterParticipes", x => new { x.CampaignId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterParticipes_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharacterParticipes_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SelectedSpecializations",
                columns: table => new
                {
                    CharacterEntityId = table.Column<int>(type: "int", nullable: false),
                    SpecializationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedSpecializations", x => new { x.CharacterEntityId, x.SpecializationsId });
                    table.ForeignKey(
                        name: "FK_SelectedSpecializations_CharacterSpecializations_SpecializationsId",
                        column: x => x.SpecializationsId,
                        principalTable: "CharacterSpecializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSpecializations_Characters_CharacterEntityId",
                        column: x => x.CharacterEntityId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterSpecializations",
                columns: new[] { "Id", "LevelMinimumForSpecialization", "Name", "RequirementId" },
                values: new object[,]
                {
                    { 1, null, "Guerrier", null },
                    { 2, null, "Mage", null },
                    { 3, null, "Voleur", null },
                    { 4, null, "Clerc", null },
                    { 5, null, "Ranger", null },
                    { 6, null, "Gardien de la Citadelle", null },
                    { 7, null, "Cavalier du Rohan", null },
                    { 8, null, "Solo", null },
                    { 9, null, "Netrunner", null },
                    { 10, null, "Techie", null },
                    { 11, null, "Fixer", null },
                    { 12, null, "Nomade", null },
                    { 13, null, "Initié de la Force", null },
                    { 14, null, "Chasseur de Primes", null },
                    { 15, null, "Contrebandier", null },
                    { 16, null, "Pilote de l'Alliance", null },
                    { 17, null, "Soldat Clone", null },
                    { 18, null, "Paladin", null },
                    { 19, null, "Barde", null },
                    { 20, null, "Artificier", null },
                    { 56, null, "Adepte de la Prophétie", null },
                    { 59, null, "Enquêteur du Mythe", null },
                    { 62, null, "Clarificateur de Niveau Infrarouge", null },
                    { 68, null, "Recrue Arasaka", null },
                    { 21, 5, "Maître d'Armes", 1 },
                    { 22, 10, "Archimage", 2 },
                    { 23, 3, "Assassin", 3 },
                    { 24, 6, "Guerrier d'Élite du Rohan", 7 },
                    { 25, 5, "Cyber-Chirurgien", 10 },
                    { 26, 1, "Padawan Jedi", 13 },
                    { 29, 1, "Adepte du Côté Obscur", 13 },
                    { 32, 3, "Samouraï des Rues", 8 },
                    { 35, 3, "Prêtre de l'Aube", 4 },
                    { 38, 2, "Archer de Lorien", 5 },
                    { 41, 2, "Hacker de Code", 9 },
                    { 44, 3, "Coureur de Blocus", 15 },
                    { 47, 3, "Chevalier du Serment", 18 },
                    { 50, 3, "Troubadour Enchanteur", 19 },
                    { 53, 4, "Traqueur de Primes", 14 },
                    { 57, 3, "Fanatique du Ver Céleste", 56 },
                    { 60, 4, "Professeur d'Occultisme Obsédé", 59 },
                    { 63, 3, "Officier de Sécurité Rouge", 62 },
                    { 69, 3, "Agent de Sécurité", 68 },
                    { 93, 8, "Briseur de la Trame Magique", 9 },
                    { 97, 100, "Concept Primordial de la Guerre", 1 },
                    { 98, 100, "Ombre Insaisissable de la Réalité", 3 },
                    { 99, 100, "Manifestation Vivante du Panthéon", 4 },
                    { 100, 100, "Dieu Ex Machina du Réseau Quantique", 9 },
                    { 101, 2, "Raconteur d'Histoires trop Longues", 19 },
                    { 27, 5, "Chevalier Jedi", 26 },
                    { 30, 6, "Seigneur Sith", 29 },
                    { 33, 7, "Cyber-Gladiateur", 32 },
                    { 36, 8, "Grand Inquisiteur", 35 },
                    { 39, 6, "Sentinelle de Mirkwood", 38 },
                    { 42, 6, "Breacher de Glace", 41 },
                    { 45, 8, "Baron du Crime Mineur", 44 },
                    { 48, 8, "Champion de la Justice", 47 },
                    { 51, 7, "Virtuose du Son", 50 },
                    { 54, 9, "Exterminateur de Cibles", 53 },
                    { 58, 6, "Héraut du Septième Sceau", 57 },
                    { 61, 8, "Initié des Grands Anciens [Fou]", 60 },
                    { 64, 7, "Superviseur Ultraviolet", 63 },
                    { 65, 14, "Seigneur de Guerre", 21 },
                    { 70, 5, "Sous-Officier Corp", 69 },
                    { 78, 12, "Érudit des Runes", 22 },
                    { 94, 14, "Technomancien Interdimensionnel", 93 },
                    { 102, 5, "Remplisseur de Formulaires en Combat", 101 },
                    { 28, 12, "Maître Jedi", 27 },
                    { 31, 15, "Empereur Sith", 30 },
                    { 34, 12, "Légende de l'Afterlife", 33 },
                    { 37, 16, "Avatar Divin", 36 },
                    { 40, 11, "Capitaine des Éclaireurs", 39 },
                    { 43, 12, "Fantôme du Cyberespace", 42 },
                    { 46, 14, "Seigneur de la Pègre", 45 },
                    { 49, 15, "Sainte Sentinelle", 48 },
                    { 52, 13, "Maître de la Cacophonie", 51 },
                    { 55, 15, "Guilde-Master", 54 },
                    { 66, 18, "Héros des Royaumes", 65 },
                    { 71, 7, "Lieutenant de Division", 70 },
                    { 79, 15, "Invocateur de la Trame", 78 },
                    { 95, 20, "Scribe de Données Stellaires", 94 },
                    { 103, 10, "Inspecteur des Normes de Pièges", 102 },
                    { 67, 20, "Demi-Dieu du Combat", 66 },
                    { 72, 9, "Capitaine de Strike Team", 71 },
                    { 80, 18, "Maître des Éléments", 79 },
                    { 96, 26, "Hacker d'I.A. Cosmique", 95 },
                    { 104, 15, "Archiviste des Caisses de Butin Vides", 103 },
                    { 73, 11, "Commandant tactique", 72 },
                    { 81, 22, "Tisseur de Réalités", 80 },
                    { 105, 25, "Grand Maître de l'Inaction Administrative", 104 },
                    { 74, 13, "Directeur de la Sécurité", 73 },
                    { 82, 25, "Gaurdien des Portes", 81 },
                    { 75, 15, "Vice-Président Militari", 74 },
                    { 83, 28, "Chronomancien Senior", 82 },
                    { 76, 18, "Chef des Opérations Noires", 75 },
                    { 84, 32, "Arpenteur des Plans", 83 },
                    { 77, 20, "PDG Cyber-Militaire", 76 },
                    { 85, 36, "Savant du Nexus Astrologique", 84 },
                    { 89, 36, "Seigneur du Vide Absolu", 84 },
                    { 86, 40, "Avatar de la Pure Énergie", 85 },
                    { 90, 40, "Catalyseur du Chaos Primordial", 89 },
                    { 87, 45, "Architecte de l'Espace-Temps", 86 },
                    { 91, 45, "Dévoreur d'Étoiles", 90 },
                    { 88, 50, "Entité Conceptuelle Éternelle", 87 },
                    { 92, 50, "Singularité Finale", 91 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_RunnerId",
                table: "Campaigns",
                column: "RunnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterParticipes_CharacterId",
                table: "CharacterParticipes",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlayerId",
                table: "Characters",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpecializations_RequirementId",
                table: "CharacterSpecializations",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSpecializations_SpecializationsId",
                table: "SelectedSpecializations",
                column: "SpecializationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterParticipes");

            migrationBuilder.DropTable(
                name: "SelectedSpecializations");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "CharacterSpecializations");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
