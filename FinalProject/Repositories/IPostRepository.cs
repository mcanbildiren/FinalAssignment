using FinalProject.Models;

namespace FinalProject.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAll();
        Post Create(Post post);
        List<Category> GetCategories();
        void Update(Post post);
        Post GetById(int id);
        void Delete(int id);
        (List<Post>, int) GetPostsWithPaged(int page, int pageSize);
    }
}
