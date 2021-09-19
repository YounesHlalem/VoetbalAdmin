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
    public class WedstrijdResultaatLogic : ILogic<WedstrijdResultaatDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly WedstrijdResultaatRepository repository;

        public WedstrijdResultaatLogic()
        {
            repository = new WedstrijdResultaatRepository(_context);
        }

        public async Task Create(WedstrijdResultaatDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<WedstrijdResultaat>(entity));
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

        public async Task<List<WedstrijdResultaatDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<WedstrijdResultaatDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<WedstrijdResultaatDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<WedstrijdResultaatDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(WedstrijdResultaatDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<WedstrijdResultaat>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
