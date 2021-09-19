using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class LidRolRepository : BaseRepository<LidRol>, IRepository<LidRol>
    {
        public LidRolRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.LidRolId == id);
        }

        public async Task<LidRol> GetById(int id)
        {
            var entity = await Get(e => e.LidRolId == id);

            return entity;
        }

        public async Task UpdateEntity(LidRol entity)
        {
            await Update(entity, e => e.LidRolId == entity.LidRolId);
        }
    }
}
