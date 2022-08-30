using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Publisher { get; set; }
        public int? CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public string? Photo { get; set; }
    }
}
