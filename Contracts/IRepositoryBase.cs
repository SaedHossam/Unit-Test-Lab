using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        T FindById(int id);
        void Create(T t);
        void Update(T t);
        void Delete(T t);
    }
}
