using System;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;

namespace VoetbalAdmin.DAL.Repositories
{
    public class TeamRepository : BaseRepository<Team>, IRepository<Team>
    {
        public TeamRepository(IDbContextCreator dbContextCreator) : base(dbContextCreator) { }

        public async Task DeleteById(int id)
        {
            await Delete(e => e.TeamId == id);
        }

        public async Task<Team> GetById(int id)
        {
            var entity = await Get(e => e.TeamId == id);

            return entity;
        }

        public async Task UpdateEntity(Team entity)
        {
            await Update(entity, e => e.TeamId == entity.TeamId);
        }
    }
}
