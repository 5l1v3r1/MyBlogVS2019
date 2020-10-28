using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using API.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;
        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _mapper = mapper;
            _blogService = blogService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var blog = await _blogService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<BlogDto>>(blog));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = await _blogService.GetByIdAsync(id);
            return Ok(_mapper.Map<BlogDto>(blog));
        }
        [HttpPost]
        public async Task<IActionResult> Post(BlogDto blog)
        {
            var blogg = await _blogService.AddAsync(_mapper.Map<Blog>(blog));
            return Created(string.Empty, _mapper.Map<BlogDto>(blogg));
        }
        [HttpPut]
        public IActionResult Put(BlogDto blog)
        {
            var blogg = _blogService.Update(_mapper.Map<Blog>(blog));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           var blog =  _blogService.GetByIdAsync(id).Result;
            _blogService.Remove(blog);
            return NoContent();
        }
        //[HttpGet("{id}/etikets")]
        //public async Task<IActionResult> GetWithEtiketsByIdAsync(int id)
        //{
        //    var category = await _blogService.GetWithEtiketsByIdAsync(id);
        //    return Ok(_mapper.Map<CategoryWithBlogDto>(category));
        //}
    }
}
