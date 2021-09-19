using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VoetbalAdmin.BLL.Mapper;
using VoetbalAdmin.DAL.Context;
using VoetbalAdmin.DAL.Entities;
using VoetbalAdmin.DAL.Repositories;
using VoetbalAdmin.DataContracts.DTO;

namespace VoetbalAdmin.BLL.Logic
{
    public class TeamLogic : ILogic<TeamDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly TeamRepository repository;

        public TeamLogic()
        {
            repository = new TeamRepository(_context);
        }

        public async Task Create(TeamDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Team>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                await repository.DeleteById(id);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<List<TeamDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<TeamDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<TeamDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<TeamDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(TeamDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Team>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
