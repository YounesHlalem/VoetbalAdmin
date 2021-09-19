using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class LidRepository : BaseRepository<Lid>, IRepository<Lid>
    {
        public LidRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.LidId == id);
        }

        public async Task<Lid> GetById(int id)
        {
            var dbContext = DbContext.CreateVoetbalAdminContext();
            var entity = await dbContext.Set<Lid>()
                .FromSqlRaw($"exec GetLidById {id}")
                .FirstOrDefaultAsync();

            return entity;

            /*
            var entity = await Get(e => e.LidId == id);

            return entity;*/
        }

        public async Task UpdateEntity(Lid entity)
        {
            await Update(entity, e => e.LidId == entity.LidId);
        }
    }
}
