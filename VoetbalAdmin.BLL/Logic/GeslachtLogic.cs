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
    public class GeslachtLogic : ILogic<GeslachtDTO>
    {
        private readonly IDbContextCreator _context = new DbContextCreator();
        private readonly GeslachtRepository repository;

        public GeslachtLogic()
        {
            repository = new GeslachtRepository(_context);
        }

        public async Task Create(GeslachtDTO entity)
        {
            try
            {
                await repository.Create(ObjectMapper.Mapper.Map<Geslacht>(entity));
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

        public async Task<List<GeslachtDTO>> GetAllAsync()
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<List<GeslachtDTO>>(await repository.GetAllAsync());
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<GeslachtDTO> GetById(int id)
        {
            try
            {
                var result = ObjectMapper.Mapper.Map<GeslachtDTO>(await repository.GetById(id));
                return result;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateEntity(GeslachtDTO entity)
        {
            try
            {
                await repository.UpdateEntity(ObjectMapper.Mapper.Map<Geslacht>(entity));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
