using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class WedstrijdResultaatConfiguration : IEntityTypeConfiguration<WedstrijdResultaat>
    {
        public void Configure(EntityTypeBuilder<WedstrijdResultaat> builder)
        {
            builder.ToTable("WedstrijdResultaat");

            builder.Property(p => p.WedstrijdId).IsRequired();
            builder.HasIndex(p => p.WedstrijdId).IsUnique();
        }
    }
}
