using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class LidConfiguration : IEntityTypeConfiguration<Lid>
    {
        public void Configure(EntityTypeBuilder<Lid> builder)
        {
            builder.ToTable("Lid");

            builder.Property(p => p.BondsNr)
               .HasMaxLength(10)
               .IsUnicode(false)
               .IsRequired();

            builder.Property(p => p.Voornaam)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(p => p.Naam)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(p => p.Adres)
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(p => p.Postcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(p => p.Stad)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(p => p.TelefoonNr)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(p => p.IsGearchiveerd).IsRequired();

            builder.HasIndex(p => p.BondsNr).IsUnique();
        }
    }
}
