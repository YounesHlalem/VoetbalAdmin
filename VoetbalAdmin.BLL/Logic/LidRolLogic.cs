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
    public class LidRolLogic : ILogic<LidRolDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly LidRolRepository repository;

        public LidRolLogic()
        {
            repository = new LidRolRepository(_context);
        }

        public async Task Create(LidRolDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<LidRol>(entity));
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

        public async Task<List<LidRolDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<LidRolDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<LidRolDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<LidRolDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(LidRolDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<LidRol>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
