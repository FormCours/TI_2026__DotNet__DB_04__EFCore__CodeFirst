using Azure;
using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class CharacterConfig : IEntityTypeConfiguration<CharacterEntity>
    {
        public void Configure(EntityTypeBuilder<CharacterEntity> builder)
        {
            builder.ToTable("Characters");

            builder.HasKey(c => c.Id)
                   .HasName("PK_Characters")
                   .IsClustered();

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                   .HasMaxLength(100)
                   .IsUnicode()
                   .IsRequired();

            builder.Property(c => c.Level)
                   .IsRequired();

            builder.Property(c => c.CreateDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(c => c.DeathDate)
                   .HasColumnType("date")
                   .IsRequired(false);

            // Contraintes
            builder.ToTable(t => t.HasCheckConstraint("CK_Characters_Level", "Level > 0"));

            // Relations

            // - One to Many : Characters / Players
            builder.HasOne(c => c.Player)
                .WithMany(p => p.Characters)
                .HasForeignKey(c => c.PlayerId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            // - One to Many : Characters / Races
            builder.HasOne(c => c.Race)
                .WithMany()
                .HasForeignKey(c => c.RaceId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            // - Many to Many : Characters / Specializations
            builder.HasMany(c => c.Specializations)
                .WithMany()
                .UsingEntity("SelectedSpecializations");


            // - Many to Many : Characters / Campaign
            builder.HasMany(c => c.Campaigns)
                .WithMany(ca => ca.Characters)
                .UsingEntity<CharacterParticipeEntity>();
        }
    }
}
