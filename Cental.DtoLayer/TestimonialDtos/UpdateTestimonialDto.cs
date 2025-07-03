using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "Ad soyad boş geçilemez.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ünvan boş geçilemez.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen bir puan seçin.")]
        public int Review { get; set; }
        [Required(ErrorMessage = "Yorum alanı boş geçilemez.")]
        public string Comment { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
