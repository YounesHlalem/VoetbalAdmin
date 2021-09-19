using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VoetbalAdmin.DAL.Context;

namespace VoetbalAdmin.DAL.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly IDbContextCreator DbContext; 

        protected BaseRepository(IDbContextCreator dbContextContextCreator)
        {
            DbContext = dbContextContextCreator;
        }

        public async Task Create(T entity)
        {
            try
            {
                using (var dbContext = DbContext.CreateVoetbalAdminContext())
                {
                    await dbContext.Set<T>().AddAsync(entity);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(Expression<Func<T, bool>> predicate)
        {
            using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                var entityToDelete = await dbContext.Set<T>().FirstOrDefaultAsync(predicate);
                if (entityToDelete != null)
                {
                    dbContext.Set<T>().Remove(entityToDelete);
                }

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                IQueryable<T> qry = dbContext.Set<T>();

                qry = includeProperties.Aggregate(qry, (current, includeProperty) => current.Include(includeProperty));

                return await qry.Where(predicate).ToListAsync();
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                IQueryable<T> qry = dbContext.Set<T>();

                qry = includeProperties.Aggregate(qry, (current, includeProperty) => current.Include(includeProperty));

                return await qry.FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            var dbContext = DbContext.CreateVoetbalAdminContext();
            string n = $"[dbo].[{typeof(T).Name}]";
            var entity = await dbContext.Set<T>().FromSqlRaw($"SELECT * FROM {n}").ToListAsync();
            return entity;

            /*using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                return await dbContext.Set<T>().ToListAsync();
            }*/
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                var result = dbContext.Set<T>().Where(predicate);
                if (result == null)
                    return new List<T>();
                return await result.ToListAsync();
            }
        }

        public async Task Update(T entity, Expression<Func<T, bool>> predicate)
        {
            using (var dbContext = DbContext.CreateVoetbalAdminContext())
            {
                var editedEntity = await dbContext.Set<T>().FirstOrDefaultAsync(predicate);
                if (editedEntity != null)
                {
                    editedEntity = entity;
                    dbContext.Set<T>().Update(editedEntity);
                }

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
