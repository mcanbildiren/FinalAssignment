using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Models;

namespace FinalProject.Core.Repositories
{
    public interface ICategoryRepository
    {
        Category Create(Category category);
    }
}
