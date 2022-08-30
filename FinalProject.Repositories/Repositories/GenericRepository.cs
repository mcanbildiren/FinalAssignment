using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositories.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {

            _dbSet = context.Set<T>();
        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _dbSet.Remove(entity);
        }


        public T GetById(int id)
        {

            return _dbSet.Find(id);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {

            return _dbSet.Where(predicate);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
