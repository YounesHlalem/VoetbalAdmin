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
    public class LidLogic : ILogic<LidDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly LidRepository repository;

        public LidLogic()
        {
            repository = new LidRepository(_context);
        }

        public async Task Create(LidDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Lid>(entity));
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

        public async Task<List<LidDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<LidDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<LidDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<LidDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(LidDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Lid>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
