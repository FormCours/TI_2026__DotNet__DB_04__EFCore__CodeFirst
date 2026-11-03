using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class PlayerConfig : IEntityTypeConfiguration<PlayerEntity>
    {
        public void Configure(EntityTypeBuilder<PlayerEntity> builder)
        {
            // Table
            builder.ToTable("Players");

            // Clef
            builder.HasKey(p => p.Id)
                   .HasName("PK_Players")
                   .IsClustered();

            // Colonnes
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                   .HasColumnName("First_Name")
                   .HasMaxLength(50)
                   .IsUnicode()  // → NVARCHAR
                   .IsRequired();

            builder.Property(p => p.LastName)
                   .HasColumnName("last_Name")
                   .HasColumnType("nvarchar(50)") // Alternative
                   .IsRequired();

            builder.Property(p => p.Pseudo)
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .IsRequired(false);

            // Index
            builder.HasIndex(p => new { p.FirstName, p.LastName })
                   .IsUnique()
                   .HasDatabaseName("IDX_Players_Name");

            // Relation

            // - One To Many avec Campaign
            builder.HasMany(p => p.CampaignRuns)
                .WithOne(ca => ca.Runner)
                .HasForeignKey(ca => ca.RunnerId)
                .IsRequired();

            // Data seeding
            builder.HasData([
                new PlayerEntity {
                    Id = 1, FirstName = "Della", LastName = "Duck", Pseudo = "MoonDuck"
                },
                new PlayerEntity {
                    Id = 2, FirstName = "Balthazar", LastName = "Picsou", Pseudo = null
                },
                new PlayerEntity {
                    Id = 3, FirstName = "Zaza", LastName = "Vanderquack", Pseudo = "TacticalPancake"
                }
            ]);
        }
    }
}
