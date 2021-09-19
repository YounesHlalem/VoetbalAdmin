using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class SeizoenRepository : BaseRepository<Seizoen>, IRepository<Seizoen>
    {
        public SeizoenRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.SeizoenId == id);
        }

        public async Task<Seizoen> GetById(int id)
        {
            var entity = await Get(e => e.SeizoenId == id);

            return entity;
        }

        public async Task UpdateEntity(Seizoen entity)
        {
            await Update(entity, e => e.SeizoenId == entity.SeizoenId);
        }
    }
}
