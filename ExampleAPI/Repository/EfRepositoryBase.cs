using ExampleAPI.DataAccess;
using ExampleAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Repository
{
    public class EfRepositoryBase<T> : IGenericRepository<T> where T : class, IEntity, new()
    {

        private readonly Context _context;
        public EfRepositoryBase(Context context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = _context.Set<T>().Find(Id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public void UpdateById(T entity, int Id)
        {
            var model = _context.Set<T>().Find(Id);
            if (model != null)
            {
                _context.Entry(model).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
