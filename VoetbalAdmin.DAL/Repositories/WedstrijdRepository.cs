using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class WedstrijdRepository : BaseRepository<Wedstrijd>, IRepository<Wedstrijd>
    {
        public WedstrijdRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.WedstrijdId == id);
        }

        public async Task<Wedstrijd> GetById(int id)
        {
            var entity = await Get(e => e.WedstrijdId == id);

            return entity;
        }

        public async Task UpdateEntity(Wedstrijd entity)
        {
            await Update(entity, e => e.WedstrijdId == entity.WedstrijdId);
        }
    }
}
