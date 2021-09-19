namespace VoetbalAdmin.DAL.Context
{
    public interface IDbContextCreator
    {
        IVoetbalAdminDbContext CreateVoetbalAdminContext();
    }
}
