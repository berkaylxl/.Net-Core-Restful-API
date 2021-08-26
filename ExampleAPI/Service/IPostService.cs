using ExampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Service
{
    public interface IPostService
    {
        void Add(Posts post);
        void Delete(int Id);
        void Update(Posts post, int Id);
        List<Posts> GetAll();
        Posts GetById(int Id);
    }
}
