using ExampleAPI.Models;
using ExampleAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostService _postsService;
        public PostController(IPostService postsService)
        {
            _postsService = postsService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _postsService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Posts post)
        {
            _postsService.Add(post);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _postsService.Delete(id);
            return Ok();
        }
        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _postsService.GetById(id);
            return Ok(result);
        }
        [HttpPut("update/{id}")]
        public IActionResult Update(Posts post, int id)
        {
            _postsService.Update(post, id);
            return Ok();
        }
    }
}
