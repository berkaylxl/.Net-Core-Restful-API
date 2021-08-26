using ExampleAPI.Models;
using ExampleAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _genericRepository;
        public PostManager(IGenericRepository<Posts> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public void Add(Posts post)
        {
            _genericRepository.Add(post);
        }

        public void Delete(int Id)
        {

            _genericRepository.Delete(Id);
        }

        public List<Posts> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public Posts GetById(int Id)
        {
            return _genericRepository.GetById(Id);
        }

        public void Update(Posts post, int Id)
        {
            _genericRepository.UpdateById(post, Id);
        }
    }
}
