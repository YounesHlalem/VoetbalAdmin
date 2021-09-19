using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VoetbalAdmin.BLL.Logic
{
    public interface ILogic<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task DeleteById(int id);
        Task UpdateEntity(T entity);
    }
}
