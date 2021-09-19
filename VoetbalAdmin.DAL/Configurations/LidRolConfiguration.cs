using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Configurations
{
    class LidRolConfiguration : IEntityTypeConfiguration<LidRol>
    {
        public void Configure(EntityTypeBuilder<LidRol> builder)
        {
            builder.ToTable("LidRol");

            builder.Property(p => p.LidId).IsRequired();
            builder.Property(p => p.RolId).IsRequired();
            builder.Property(p => p.Begindatum).IsRequired();
        }
    }
}
