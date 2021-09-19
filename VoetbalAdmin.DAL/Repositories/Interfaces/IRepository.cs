using System.Threading.Tasks;

namespace VoetbalAdmin.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task DeleteById(int id);
        Task UpdateEntity(T entity);
    }
}
