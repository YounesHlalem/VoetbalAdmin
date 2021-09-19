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
    public class ReeksLogic : ILogic<ReeksDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly ReeksRepository repository;

        public ReeksLogic()
        {
            repository = new ReeksRepository(_context);
        }

        public async Task Create(ReeksDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Reeks>(entity));
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

        public async Task<List<ReeksDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<ReeksDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<ReeksDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<ReeksDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(ReeksDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Reeks>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
