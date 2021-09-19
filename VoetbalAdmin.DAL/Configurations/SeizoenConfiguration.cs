using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class SeizoenConfiguration : IEntityTypeConfiguration<Seizoen>
    {
        public void Configure(EntityTypeBuilder<Seizoen> builder)
        {
            builder.ToTable("Seizoen");

            builder.Property(p => p.Naam)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsRequired();
            builder.Property(p => p.Begindatum).IsRequired();
            builder.Property(p => p.IsActief).IsRequired();

            builder.HasIndex(p => p.Naam).IsUnique();
        }
    }
}
