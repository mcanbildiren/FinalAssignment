using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinalProject.Core.DTOs;
using FinalProject.Core.Repositories;
using FinalProject.Core.Services;
using FinalProject.Core.UnitOfWorks;

namespace FinalProject.Services.Services
{
    public class GenericService<TEntity, TDto> : IGenericService<TEntity, TDto> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //public CustomResponseDto<List<PostCreateDto>> Create(TDto entity)
        //{
        //    TEntity t = _mapper.Map<TEntity>(entity);

        //    _repository.Create(t);
        //    _unitOfWork.Commit();
        //    return _mapper.Map<TDto>(t);

        //}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TDto GetById(int id)
        {
            var entity = _repository.GetById(id);

            return _mapper.Map<TDto>(entity);

        }

        public CustomResponseDto<List<PostDto>> GetAll()
        {
            var posts = _repository.GetAll();

            var postDtoList = _mapper.Map<List<PostDto>>(posts);


            return CustomResponseDto<List<PostDto>>.Success(200, postDtoList);

        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            // where.take(1).skip(2).orderby().tolist(),

            return _repository.Where(predicate);
        }

        public CustomResponseDto<List<PostCreateDto>> Create(TDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
