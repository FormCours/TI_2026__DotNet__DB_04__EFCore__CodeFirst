using Demo_EFCore_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_EFCore_02.DAL.Configs
{
    internal class CharacterParticipeConfig : IEntityTypeConfiguration<CharacterParticipeEntity>
    {
        public void Configure(EntityTypeBuilder<CharacterParticipeEntity> builder)
        {
            builder.ToTable("CharacterParticipes");

            builder.Property(cp => cp.IsNPC)
                   .HasDefaultValue(false);
        }
    }
}
