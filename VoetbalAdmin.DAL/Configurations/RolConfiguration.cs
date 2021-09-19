using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol");

            builder.Property(p => p.Naam)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired();

            builder.HasIndex(p => p.Naam).IsUnique();

            builder.HasData(new Rol { RolId = 1, Naam = "Voorzitter" });
            builder.HasData(new Rol { RolId = 2, Naam = "Bestuurslid" });
            builder.HasData(new Rol { RolId = 3, Naam = "Secretaris" });
            builder.HasData(new Rol { RolId = 4, Naam = "Penningmeester" });
            builder.HasData(new Rol { RolId = 5, Naam = "Jeugdcoördinator" });
            builder.HasData(new Rol { RolId = 6, Naam = "Speler" });
            
        }
    }
}
