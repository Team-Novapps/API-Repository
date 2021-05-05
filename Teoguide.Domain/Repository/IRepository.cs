using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Teoguide.Domain.Repository
{
    public interface IRepository<T>
    {
        Task<int> Save(T entity);
        Task<int> Update(int id, T entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
    }
}
