using ExampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Repository
{
    public interface IGenericRepository<T> where T :class,IEntity
    {
        void Add(T entity);
        void UpdateById(T entity, int Id);
        void Delete(int Id);
        T GetById(int Id);
        List<T> GetAll();

    }
}
