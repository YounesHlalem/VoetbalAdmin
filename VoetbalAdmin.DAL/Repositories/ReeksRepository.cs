using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class ReeksRepository : BaseRepository<Reeks>, IRepository<Reeks>
    {
        public ReeksRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.ReeksId == id);
        }

        public async Task<Reeks> GetById(int id)
        {
            var entity = await Get(e => e.ReeksId == id);

            return entity;
        }

        public async Task UpdateEntity(Reeks entity)
        {
            await Update(entity, e => e.ReeksId == entity.ReeksId);
        }
    }
}
