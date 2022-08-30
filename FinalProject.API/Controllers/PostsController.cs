using AutoMapper;
using FinalProject.Core.DTOs;
using FinalProject.Core.Models;
using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPostService _postService;
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IMapper mapper, IPostService postService, IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _postService = postService;
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            var response = _postService.GetAll();

            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }

        [HttpPost]
        public IActionResult Create(PostCreateDto postCreateDto)
        {
            _postRepository.Create(_mapper.Map<Post>(postCreateDto));
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _postService.Delete(id);

            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }

        [HttpPut]
        public IActionResult Update(PostCreateDto postCreateDto)
        {
            _postRepository.Update(_mapper.Map<Post>(postCreateDto));
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
