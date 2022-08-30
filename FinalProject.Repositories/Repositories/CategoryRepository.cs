using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Models;
using FinalProject.Core.Repositories;

namespace FinalProject.Repositories.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public Category Create(Category category)
        {
            _context.Categories.Add(category);
            return category;
        }
    }
}
