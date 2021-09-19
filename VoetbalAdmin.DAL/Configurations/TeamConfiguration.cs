using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");

            builder.Property(p => p.Naam)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsRequired();
            builder.HasIndex(p => p.Naam).IsUnique();
        }
    }
}
