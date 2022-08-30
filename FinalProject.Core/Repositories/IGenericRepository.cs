using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Repositories
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
