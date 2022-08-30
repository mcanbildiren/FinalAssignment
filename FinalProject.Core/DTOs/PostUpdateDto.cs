using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.DTOs
{
    public class PostUpdateDto
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Başlık en fazla 50 karakterden oluşabilir!")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik boş bırakılamaz!")]
        public string Text { get; set; }

        [StringLength(50, ErrorMessage = "Yazar ismi en fazla 50 karakterden oluşabilir!")]
        [Required(ErrorMessage = "Yazar ismi boş bırakılamaz!")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Kategori boş bırakılamaz!")]
        public int? CategoryId { get; set; }
    }
}
