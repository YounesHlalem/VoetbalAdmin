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
    public class RolLogic : ILogic<RolDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly RolRepository repository;

        public RolLogic()
        {
            repository = new RolRepository(_context);
        }

        public async Task Create(RolDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Rol>(entity));
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

        public async Task<List<RolDTO>> GetAllAsync()
        {
            try
            {
                var result = await repository.GetAllAsync();
                return ObjectMapper.Mapper.Map<List<RolDTO>>(result);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<RolDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<RolDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(RolDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Rol>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
