using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(Guid Id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        bool Delete(Guid id);
    }
}
