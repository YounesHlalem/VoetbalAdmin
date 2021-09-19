using Microsoft.EntityFrameworkCore;

namespace VoetbalAdmin.DAL.Context
{
    public class DbContextCreator : IDbContextCreator
    {
        public DbContextCreator() 
        {
        }

        public IVoetbalAdminDbContext CreateVoetbalAdminContext()
        {
            var context = new VoetbalAdminDBContext(new DbContextOptions<VoetbalAdminDBContext>());
            return context;
        }
    }
}
