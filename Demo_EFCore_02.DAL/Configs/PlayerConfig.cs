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
        }
    }
}
