using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.DTOs;
using FinalProject.Core.Models;

namespace FinalProject.Core.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAll();
        (List<Post>, int) GetAllWithPaged(int page, int pageSize);
        Post Create(Post post);
        void Delete(int id);
        void Update(Post post);
        bool Any(Expression<Func<Post, bool>> predicate);
    }
}
