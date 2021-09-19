using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class ReeksConfiguration : IEntityTypeConfiguration<Reeks>
    {
        public void Configure(EntityTypeBuilder<Reeks> builder)
        {
            builder.ToTable("Reeks");

            builder.Property(p => p.Naam)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsRequired();
            builder.HasIndex(p => p.Naam).IsUnique();
        }
    }
}
