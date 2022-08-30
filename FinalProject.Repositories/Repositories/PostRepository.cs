using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Models;
using FinalProject.Core.Repositories;

namespace FinalProject.Repositories.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Any(Expression<Func<Post, bool>> predicate)
        {
            return _context.Posts.Any(predicate);
        }

        public Post Create(Post post)
        {
            _context.Add(post);
            return post;
        }

        public void Delete(int id)
        {
            var entity = _context.Posts.Find(id);
            _context.Remove(entity);
        }
        public void Update(Post post)
        {
            _context.Update(post);
        }
        public List<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        public (List<Post>, int) GetAllWithPaged(int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
