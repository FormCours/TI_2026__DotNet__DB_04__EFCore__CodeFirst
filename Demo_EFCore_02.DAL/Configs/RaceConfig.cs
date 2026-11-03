using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class RaceConfig : IEntityTypeConfiguration<RaceEntity>
    {
        public void Configure(EntityTypeBuilder<RaceEntity> builder)
        {
            builder.ToTable("Races");

            builder.HasKey(r => r.Id)
                   .HasName("PK_Races")
                   .IsClustered();

            builder.Property(r => r.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(r => r.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(r => r.AlternateName)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.HasIndex(r => r.Name)
                   .IsUnique()
                   .HasDatabaseName("IDX_Races_Name");

            builder.HasData([
                new RaceEntity() { Id = 1, Name = "Humain" },
                new RaceEntity() { Id = 2, Name = "Canard" },
                new RaceEntity() { Id = 3, Name = "Elfe" },
                new RaceEntity() { Id = 4, Name = "Panda" },
                new RaceEntity() { Id = 5, Name = "Nain" },
                new RaceEntity() { Id = 6, Name = "Halfelin" },
                new RaceEntity() { Id = 7, Name = "Gnome" },
                new RaceEntity() { Id = 8, Name = "Demi-Orque" },
                new RaceEntity() { Id = 9, Name = "Tieffelin" },
                new RaceEntity() { Id = 10, Name = "Drakéide" },
                new RaceEntity() { Id = 11, Name = "Aasimar" },
                new RaceEntity() { Id = 12, Name = "Goliath" },
                new RaceEntity() { Id = 13, Name = "Githyanki" },
                new RaceEntity() { Id = 14, Name = "Githzerai" },
                new RaceEntity() { Id = 15, Name = "Forgelinger" },
                new RaceEntity() { Id = 16, Name = "Félys" },
                new RaceEntity() { Id = 17, Name = "Genasi" },
                new RaceEntity() { Id = 18, Name = "Kenku" },
                new RaceEntity() { Id = 19, Name = "Tabaxi" },
                new RaceEntity() { Id = 20, Name = "Lézardien" },
                new RaceEntity() { Id = 21, Name = "Firbolg" },
                new RaceEntity() { Id = 22, Name = "Wookiee" },
                new RaceEntity() { Id = 23, Name = "Twi'lek" },
                new RaceEntity() { Id = 24, Name = "Zabrak" },
                new RaceEntity() { Id = 25, Name = "Rodien" },
                new RaceEntity() { Id = 26, Name = "Trandoshan" },
                new RaceEntity() { Id = 27, Name = "Mon Calamari" },
                new RaceEntity() { Id = 28, Name = "Bothan" },
                new RaceEntity() { Id = 29, Name = "Chiss" },
                new RaceEntity() { Id = 30, Name = "Togruta" },
                new RaceEntity() { Id = 31, Name = "Kel Dor" },
                new RaceEntity() { Id = 32, Name = "Sullustéen" },
                new RaceEntity() { Id = 33, Name = "Ithorien" },
                new RaceEntity() { Id = 34, Name = "Jawa" },
                new RaceEntity() { Id = 35, Name = "Ewok" },
                new RaceEntity() { Id = 36, Name = "Gamorréen" },
                new RaceEntity() { Id = 37, Name = "Geonosien" },
                new RaceEntity() { Id = 38, Name = "Kaminoen" },
                new RaceEntity() { Id = 39, Name = "Mirialan" },
                new RaceEntity() { Id = 40, Name = "Nautolan" },
                new RaceEntity() { Id = 41, Name = "Pau'an" },
                new RaceEntity() { Id = 42, Name = "Hobbit" },
                new RaceEntity() { Id = 43, Name = "Uruk-hai" },
                new RaceEntity() { Id = 44, Name = "Orque" },
                new RaceEntity() { Id = 45, Name = "Gobelin" },
                new RaceEntity() { Id = 46, Name = "Ent" },
                new RaceEntity() { Id = 47, Name = "Semi-Elfe" },
                new RaceEntity() { Id = 48, Name = "Dúnadan" },
                new RaceEntity() { Id = 49, Name = "Puckel-Man" },
                new RaceEntity() { Id = 50, Name = "Avari" },
                new RaceEntity() { Id = 51, Name = "Beornide" },
                new RaceEntity() { Id = 52, Name = "Humain Augmenté" },
                new RaceEntity() { Id = 53, Name = "Exotique Biosculpté" },
                new RaceEntity() { Id = 54, Name = "I.A. Libre" },
                new RaceEntity() { Id = 55, Name = "Android", AlternateName="Répliquant" },
                new RaceEntity() { Id = 56, Name = "Cyborg Full-Body" },
                new RaceEntity() { Id = 57, Name = "Clone de Lignée" },
                new RaceEntity() { Id = 58, Name = "Troll" },
                new RaceEntity() { Id = 59, Name = "Néo-Dauphin Évolué" },
                new RaceEntity() { Id = 60, Name = "Néo-Chimpanzé Évolué" },
                new RaceEntity() { Id = 61, Name = "Génétique Muté" },
                new RaceEntity() { Id = 62, Name = "Post-Humain Numérique" },
                new RaceEntity() { Id = 63, Name = "Humain Isolé" },
                new RaceEntity() { Id = 64, Name = "Goule des Décharges" },
                new RaceEntity() { Id = 65, Name = "Transhumain Éco-conçu" },
                new RaceEntity() { Id = 66, Name = "Drone de Conscience" },
                new RaceEntity() { Id = 67, Name = "Broo" },
                new RaceEntity() { Id = 68, Name = "Uz", AlternateName="Troll Sombre" },
                new RaceEntity() { Id = 69, Name = "Mostali", AlternateName="Nain d'Argile" },
                new RaceEntity() { Id = 70, Name = "Durulz" },
                new RaceEntity() { Id = 71, Name = "Tcho-Tcho" },
                new RaceEntity() { Id = 72, Name = "Profond", AlternateName="Deep One" },
                new RaceEntity() { Id = 73, Name = "Goule de Lovecraft" },
                new RaceEntity() { Id = 74, Name = "Mi-Go" },
                new RaceEntity() { Id = 75, Name = "Insecte de Shaggai" },
                new RaceEntity() { Id = 76, Name = "Morlock" },
                new RaceEntity() { Id = 77, Name = "Éloi" },
                new RaceEntity() { Id = 78, Name = "Automate à Vapeur" },
                new RaceEntity() { Id = 79, Name = "Homunculus de Mercure" },
                new RaceEntity() { Id = 80, Name = "Myconide Écorché" },
                new RaceEntity() { Id = 81, Name = "Skaven" },
                new RaceEntity() { Id = 82, Name = "Fimir" },
                new RaceEntity() { Id = 83, Name = "Homme-Lézard de la jungle" },
                new RaceEntity() { Id = 84, Name = "Zoat" },
                new RaceEntity() { Id = 85, Name = "Méta-Baron Mutant" },
                new RaceEntity() { Id = 86, Name = "Nephilim" },
                new RaceEntity() { Id = 87, Name = "Sélénite" },
                new RaceEntity() { Id = 88, Name = "Méduse Flottante" },
                new RaceEntity() { Id = 89, Name = "Nuage Pensant" },
                new RaceEntity() { Id = 90, Name = "Insectoïde Vespiforme" },
                new RaceEntity() { Id = 91, Name = "Plante Carnivore Anthropomorphe" },
                new RaceEntity() { Id = 92, Name = "Ombre Vivante" },
                new RaceEntity() { Id = 93, Name = "Silico-Forme Cristallin" },
                new RaceEntity() { Id = 94, Name = "Spectre d'Énergie Ectoplasmique" }
            ]);


        }
    }
}
