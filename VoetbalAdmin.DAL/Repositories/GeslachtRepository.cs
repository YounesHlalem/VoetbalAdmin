using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class GeslachtRepository : BaseRepository<Geslacht>, IRepository<Geslacht>
    {
        public GeslachtRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.GeslachtId == id);
        }

        public async Task<Geslacht> GetById(int id)
        {
            var entity = await Get(e => e.GeslachtId == id);

            return entity;
        }

        public async Task UpdateEntity(Geslacht entity)
        {
            await Update(entity, e => e.GeslachtId == entity.GeslachtId);
        }
    }
}
