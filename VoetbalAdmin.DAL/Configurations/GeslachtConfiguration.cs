using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class GeslachtConfiguration : IEntityTypeConfiguration<Geslacht>
    {
        public void Configure(EntityTypeBuilder<Geslacht> builder)
        {
            builder.ToTable("Geslacht");

            builder.Property(p => p.Naam)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();

            builder.HasIndex(p => p.Naam).IsUnique();

            builder.HasData(new Geslacht { GeslachtId = 1, Naam = "Man"});
            builder.HasData(new Geslacht{ GeslachtId = 2, Naam = "Vrouw"});
        }
    }
}
