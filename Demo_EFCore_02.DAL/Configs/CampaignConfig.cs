using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class CampaignConfig : IEntityTypeConfiguration<CampaignEntity>
    {
        public void Configure(EntityTypeBuilder<CampaignEntity> builder)
        {
            builder.ToTable("Campaigns");

            builder.HasKey(ca => ca.Id)
                .HasName("PK_Campaigns")
                .IsClustered();

            builder.Property(ca => ca.Id)
                .ValueGeneratedOnAdd();

            builder.Property(ca => ca.Title)
                .HasMaxLength(500)
                .IsUnicode()
                .IsRequired();

            builder.Property(ca => ca.Univers)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            builder.Property(ca => ca.StartDate)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(ca => ca.EndDate)
                .HasColumnType("date")
                .IsRequired(false);
        }
    }
}
