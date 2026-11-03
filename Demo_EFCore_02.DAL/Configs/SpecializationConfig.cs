using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class SpecializationConfig : IEntityTypeConfiguration<SpecializationEntity>
    {
        public void Configure(EntityTypeBuilder<SpecializationEntity> builder)
        {
            builder.ToTable("CharacterSpecializations");

            builder.HasKey(s => s.Id)
                   .HasName("PK_CharacterSpecializations")
                   .IsClustered();

            builder.Property(s => s.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(s => s.MinLevel)
                   .HasColumnName("LevelMinimumForSpecialization")
                   .IsRequired(false);

            // ↓ Relation recursive
            builder.HasOne(s => s.Requirement)
                .WithMany(s => s.SubSpecializations)
                .HasForeignKey(s => s.RequirementId)
                .IsRequired(false);

            // Data
            List<SpecializationEntity> specializations = [
                new() { Id = 1, Name = "Guerrier"},
                new() { Id = 2, Name = "Mage"},
                new() { Id = 3, Name = "Voleur"},
                new() { Id = 4, Name = "Clerc"},
                new() { Id = 5, Name = "Ranger"},
                new() { Id = 6, Name = "Gardien de la Citadelle"},
                new() { Id = 7, Name = "Cavalier du Rohan"},
                new() { Id = 8, Name = "Solo"},
                new() { Id = 9, Name = "Netrunner"},
                new() { Id = 10, Name = "Techie"},
                new() { Id = 11, Name = "Fixer"},
                new() { Id = 12, Name = "Nomade"},
                new() { Id = 13, Name = "Initié de la Force"},
                new() { Id = 14, Name = "Chasseur de Primes"},
                new() { Id = 15, Name = "Contrebandier"},
                new() { Id = 16, Name = "Pilote de l'Alliance"},
                new() { Id = 17, Name = "Soldat Clone"},
                new() { Id = 18, Name = "Paladin"},
                new() { Id = 19, Name = "Barde"},
                new() { Id = 20, Name = "Artificier"},
                new() { Id = 21, Name = "Maître d'Armes", MinLevel = 5, RequirementId = 1 },
                new() { Id = 22, Name = "Archimage", MinLevel = 10, RequirementId = 2 },
                new() { Id = 23, Name = "Assassin", MinLevel = 3, RequirementId = 3 },
                new() { Id = 24, Name = "Guerrier d'Élite du Rohan", MinLevel = 6, RequirementId = 7 },
                new() { Id = 25, Name = "Cyber-Chirurgien", MinLevel = 5, RequirementId = 10 },
                new() { Id = 26, Name = "Padawan Jedi", MinLevel = 1, RequirementId = 13 },
                new() { Id = 27, Name = "Chevalier Jedi", MinLevel = 5, RequirementId = 26 },
                new() { Id = 28, Name = "Maître Jedi", MinLevel = 12, RequirementId = 27 },
                new() { Id = 29, Name = "Adepte du Côté Obscur", MinLevel = 1, RequirementId = 13 },
                new() { Id = 30, Name = "Seigneur Sith", MinLevel = 6, RequirementId = 29 },
                new() { Id = 31, Name = "Empereur Sith", MinLevel = 15, RequirementId = 30 },
                new() { Id = 32, Name = "Samouraï des Rues", MinLevel = 3, RequirementId = 8 },
                new() { Id = 33, Name = "Cyber-Gladiateur", MinLevel = 7, RequirementId = 32 },
                new() { Id = 34, Name = "Légende de l'Afterlife", MinLevel = 12, RequirementId = 33 },
                new() { Id = 35, Name = "Prêtre de l'Aube", MinLevel = 3, RequirementId = 4 },
                new() { Id = 36, Name = "Grand Inquisiteur", MinLevel = 8, RequirementId = 35 },
                new() { Id = 37, Name = "Avatar Divin", MinLevel = 16, RequirementId = 36 },
                new() { Id = 38, Name = "Archer de Lorien", MinLevel = 2, RequirementId = 5 },
                new() { Id = 39, Name = "Sentinelle de Mirkwood", MinLevel = 6, RequirementId = 38 },
                new() { Id = 40, Name = "Capitaine des Éclaireurs", MinLevel = 11, RequirementId = 39 },
                new() { Id = 41, Name = "Hacker de Code", MinLevel = 2, RequirementId = 9 },
                new() { Id = 42, Name = "Breacher de Glace", MinLevel = 6, RequirementId = 41 },
                new() { Id = 43, Name = "Fantôme du Cyberespace", MinLevel = 12, RequirementId = 42 },
                new() { Id = 44, Name = "Coureur de Blocus", MinLevel = 3, RequirementId = 15 },
                new() { Id = 45, Name = "Baron du Crime Mineur", MinLevel = 8, RequirementId = 44 },
                new() { Id = 46, Name = "Seigneur de la Pègre", MinLevel = 14, RequirementId = 45 },
                new() { Id = 47, Name = "Chevalier du Serment", MinLevel = 3, RequirementId = 18 },
                new() { Id = 48, Name = "Champion de la Justice", MinLevel = 8, RequirementId = 47 },
                new() { Id = 49, Name = "Sainte Sentinelle", MinLevel = 15, RequirementId = 48 },
                new() { Id = 50, Name = "Troubadour Enchanteur", MinLevel = 3, RequirementId = 19 },
                new() { Id = 51, Name = "Virtuose du Son", MinLevel = 7, RequirementId = 50 },
                new() { Id = 52, Name = "Maître de la Cacophonie", MinLevel = 13, RequirementId = 51 },
                new() { Id = 53, Name = "Traqueur de Primes", MinLevel = 4, RequirementId = 14 },
                new() { Id = 54, Name = "Exterminateur de Cibles", MinLevel = 9, RequirementId = 53 },
                new() { Id = 55, Name = "Guilde-Master", MinLevel = 15, RequirementId = 54 },
                new() { Id = 56, Name = "Adepte de la Prophétie"},
                new() { Id = 57, Name = "Fanatique du Ver Céleste", MinLevel = 3, RequirementId = 56 },
                new() { Id = 58, Name = "Héraut du Septième Sceau", MinLevel = 6, RequirementId = 57 },
                new() { Id = 59, Name = "Enquêteur du Mythe"},
                new() { Id = 60, Name = "Professeur d'Occultisme Obsédé", MinLevel = 4, RequirementId = 59 },
                new() { Id = 61, Name = "Initié des Grands Anciens [Fou]", MinLevel = 8, RequirementId = 60 },
                new() { Id = 62, Name = "Clarificateur de Niveau Infrarouge"},
                new() { Id = 63, Name = "Officier de Sécurité Rouge", MinLevel = 3, RequirementId = 62 },
                new() { Id = 64, Name = "Superviseur Ultraviolet", MinLevel = 7, RequirementId = 63 },
                new() { Id = 65, Name = "Seigneur de Guerre", MinLevel = 14, RequirementId = 21 },
                new() { Id = 66, Name = "Héros des Royaumes", MinLevel = 18, RequirementId = 65 },
                new() { Id = 67, Name = "Demi-Dieu du Combat", MinLevel = 20, RequirementId = 66 },
                new() { Id = 68, Name = "Recrue Arasaka"},
                new() { Id = 69, Name = "Agent de Sécurité", MinLevel = 3, RequirementId = 68 },
                new() { Id = 70, Name = "Sous-Officier Corp", MinLevel = 5, RequirementId = 69 },
                new() { Id = 71, Name = "Lieutenant de Division", MinLevel = 7, RequirementId = 70 },
                new() { Id = 72, Name = "Capitaine de Strike Team", MinLevel = 9, RequirementId = 71 },
                new() { Id = 73, Name = "Commandant tactique", MinLevel = 11, RequirementId = 72 },
                new() { Id = 74, Name = "Directeur de la Sécurité", MinLevel = 13, RequirementId = 73 },
                new() { Id = 75, Name = "Vice-Président Militari", MinLevel = 15, RequirementId = 74 },
                new() { Id = 76, Name = "Chef des Opérations Noires", MinLevel = 18, RequirementId = 75 },
                new() { Id = 77, Name = "PDG Cyber-Militaire", MinLevel = 20, RequirementId = 76 },
                new() { Id = 78, Name = "Érudit des Runes", MinLevel = 12, RequirementId = 22 },
                new() { Id = 79, Name = "Invocateur de la Trame", MinLevel = 15, RequirementId = 78 },
                new() { Id = 80, Name = "Maître des Éléments", MinLevel = 18, RequirementId = 79 },
                new() { Id = 81, Name = "Tisseur de Réalités", MinLevel = 22, RequirementId = 80 },
                new() { Id = 82, Name = "Gaurdien des Portes", MinLevel = 25, RequirementId = 81 },
                new() { Id = 83, Name = "Chronomancien Senior", MinLevel = 28, RequirementId = 82 },
                new() { Id = 84, Name = "Arpenteur des Plans", MinLevel = 32, RequirementId = 83 },
                new() { Id = 85, Name = "Savant du Nexus Astrologique", MinLevel = 36, RequirementId = 84 },
                new() { Id = 86, Name = "Avatar de la Pure Énergie", MinLevel = 40, RequirementId = 85 },
                new() { Id = 87, Name = "Architecte de l'Espace-Temps", MinLevel = 45, RequirementId = 86 },
                new() { Id = 88, Name = "Entité Conceptuelle Éternelle", MinLevel = 50, RequirementId = 87 },
                new() { Id = 89, Name = "Seigneur du Vide Absolu", MinLevel = 36, RequirementId = 84 },
                new() { Id = 90, Name = "Catalyseur du Chaos Primordial", MinLevel = 40, RequirementId = 89 },
                new() { Id = 91, Name = "Dévoreur d'Étoiles", MinLevel = 45, RequirementId = 90 },
                new() { Id = 92, Name = "Singularité Finale", MinLevel = 50, RequirementId = 91 },
                new() { Id = 93, Name = "Briseur de la Trame Magique", MinLevel = 8, RequirementId = 9 },
                new() { Id = 94, Name = "Technomancien Interdimensionnel", MinLevel = 14, RequirementId = 93 },
                new() { Id = 95, Name = "Scribe de Données Stellaires", MinLevel = 20, RequirementId = 94 },
                new() { Id = 96, Name = "Hacker d'I.A. Cosmique", MinLevel = 26, RequirementId = 95 },
                new() { Id = 97, Name = "Concept Primordial de la Guerre", MinLevel = 100, RequirementId = 1 },
                new() { Id = 98, Name = "Ombre Insaisissable de la Réalité", MinLevel = 100, RequirementId = 3 },
                new() { Id = 99, Name = "Manifestation Vivante du Panthéon", MinLevel = 100, RequirementId = 4 },
                new() { Id = 100, Name = "Dieu Ex Machina du Réseau Quantique", MinLevel = 100, RequirementId = 9 },
                new() { Id = 101, Name = "Raconteur d'Histoires trop Longues", MinLevel = 2, RequirementId = 19 },
                new() { Id = 102, Name = "Remplisseur de Formulaires en Combat", MinLevel = 5, RequirementId = 101 },
                new() { Id = 103, Name = "Inspecteur des Normes de Pièges", MinLevel = 10, RequirementId = 102 },
                new() { Id = 104, Name = "Archiviste des Caisses de Butin Vides", MinLevel = 15, RequirementId = 103 },
                new() { Id = 105, Name = "Grand Maître de l'Inaction Administrative", MinLevel = 25, RequirementId = 104 }
            ];
            builder.HasData(specializations);
        }
    }
}
