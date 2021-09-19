using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class WedstrijdResultaatRepository : BaseRepository<WedstrijdResultaat>, IRepository<WedstrijdResultaat>
    {
        public WedstrijdResultaatRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.WedstrijdResultaatId == id);
        }

        public async Task<WedstrijdResultaat> GetById(int id)
        {
            var entity = await Get(e => e.WedstrijdResultaatId == id);

            return entity;
        }

        public async Task UpdateEntity(WedstrijdResultaat entity)
        {
            await Update(entity, e => e.WedstrijdResultaatId == entity.WedstrijdResultaatId);
        }
    }
}
