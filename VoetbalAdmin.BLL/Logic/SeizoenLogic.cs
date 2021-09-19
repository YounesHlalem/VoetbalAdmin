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
    public class SeizoenLogic : ILogic<SeizoenDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly SeizoenRepository repository;

        public SeizoenLogic()
        {
            repository = new SeizoenRepository(_context);
        }

        public async Task Create(SeizoenDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Seizoen>(entity));
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

        public async Task<List<SeizoenDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<SeizoenDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<SeizoenDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<SeizoenDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(SeizoenDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Seizoen>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
