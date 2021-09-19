using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class RolRepository : BaseRepository<Rol>, IRepository<Rol>
    {
        public RolRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.RolId == id);
        }

        public async Task<Rol> GetById(int id)
        {
            var entity = await Get(e => e.RolId == id);

            return entity;
        }

        public async Task UpdateEntity(Rol entity)
        {
            await Update(entity, e => e.RolId == entity.RolId);
        }
    }
}
