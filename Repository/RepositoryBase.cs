using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public DB_Context _context { get; set; }

        protected RepositoryBase(DB_Context context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T t)
        {
             _context.Set<T>().Add(t);
        }
        public void Update(T t)
        {
            _context.Set<T>().Update(t);
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
        }


    }
}
