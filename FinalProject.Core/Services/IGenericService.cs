using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.DTOs;

namespace FinalProject.Core.Services
{
    public interface IGenericService<TEntity, TDto>
    {

        CustomResponseDto<List<PostDto>> GetAll();

        TDto GetById(int id);

        CustomResponseDto<List<PostCreateDto>> Create(TDto entity);

        void Update(TEntity entity);

        void Delete(int id);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
    }
}
