using Microsoft.EntityFrameworkCore;
using VoetbalAdmin.DAL.Configurations;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL
{
    public class VoetbalAdminDBContext : DbContext, IVoetbalAdminDbContext
    {
        public VoetbalAdminDBContext(DbContextOptions<VoetbalAdminDBContext> ctxOptions) : base(ctxOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS; initial catalog=VoetbalAdmin; integrated security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new GeslachtConfiguration());
            modelBuilder.ApplyConfiguration(new LidRolConfiguration());
            modelBuilder.ApplyConfiguration(new LidConfiguration());
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new ReeksConfiguration());
            modelBuilder.ApplyConfiguration(new SeizoenConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new WedstrijdConfiguration());
            modelBuilder.ApplyConfiguration(new WedstrijdResultaatConfiguration());
        }

        public DbSet<Geslacht> Geslacht { get; set; }
        public DbSet<Lid> Lid { get; set; }
        public DbSet<LidRol> LidRol { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Reeks> Reeks { get; set; }
        public DbSet<Seizoen> Seizoen { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Wedstrijd> Wedstrijd { get; set; }
        public DbSet<WedstrijdResultaat> WedstrijdResultaat { get; set; }

    }
}
