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
    public class WedstrijdLogic : ILogic<WedstrijdDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly WedstrijdRepository repository;

        public WedstrijdLogic()
        {
            repository = new WedstrijdRepository(_context);
        }

        public async Task Create(WedstrijdDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Wedstrijd>(entity));
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

        public async Task<List<WedstrijdDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<WedstrijdDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<WedstrijdDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<WedstrijdDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(WedstrijdDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Wedstrijd>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
