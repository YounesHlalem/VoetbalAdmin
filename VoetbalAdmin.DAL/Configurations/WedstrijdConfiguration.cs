using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class WedstrijdConfiguration : IEntityTypeConfiguration<Wedstrijd>
    {
        public void Configure(EntityTypeBuilder<Wedstrijd> builder)
        {
            builder.ToTable("Wedstrijd");

            builder.Property(p => p.TeamThuisId).IsRequired();
            builder.Property(p => p.TeamUitId).IsRequired();
        }
    }
}
