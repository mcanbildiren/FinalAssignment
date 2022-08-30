using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinalProject.Core.DTOs;
using FinalProject.Core.Models;
using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;

namespace FinalProject.Services.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public PostService(IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository, IPostRepository postRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _postRepository = postRepository;
        }

        public CustomResponseDto<PostDto> Create(PostCreateDto request)
        {
            var newPost = _mapper.Map<Post>(request);

            _postRepository.Create(newPost);
            _unitOfWork.Commit();

            var newPostDto = _mapper.Map<PostDto>(newPost);

            return CustomResponseDto<PostDto>.Success(201, newPostDto);
        }

        public CustomResponseDto<string> Delete(int id)
        {
            if (!_postRepository.Any(x => x.Id == id))
            {
                return CustomResponseDto<string>.Fail($"Id'si {id} olan ürün bulunamamıştır", 404);

            }

            _postRepository.Delete(id);

            _unitOfWork.Commit();

            return CustomResponseDto<string>.Success(204, String.Empty);
        }

        public CustomResponseDto<List<PostDto>> GetAll()
        {
            var posts = _postRepository.GetAll();

            var postDtoList = _mapper.Map<List<PostDto>>(posts);

            return CustomResponseDto<List<PostDto>>.Success(200, postDtoList);
        }

        public CustomResponseDto<PostDto> Update(PostUpdateDto request)
        {
            var newPost = _mapper.Map<Post>(request);

            _postRepository.Update(newPost);
            _unitOfWork.Commit();

            var newPostDto = _mapper.Map<PostDto>(newPost);

            return CustomResponseDto<PostDto>.Success(201, newPostDto);
        }
    }
}
