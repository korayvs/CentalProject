using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.BookingDtos
{
    public class CreateBookingDto
    {        
        [Required(ErrorMessage = "Alış yeri boş geçilemez.")]
        public string PickUpLocation { get; set; }
        [Required(ErrorMessage = "İade yeri boş geçilemez.")]
        public string DropOffLocation { get; set; }
        [Required(ErrorMessage = "Alış tarihi boş geçilemez.")]
        public DateTime PickUpDate { get; set; }
        [Required(ErrorMessage = "İade tarihi boş geçilemez.")]
        public DateTime DropOffDate { get; set; }
        public bool? IsApproved { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "Bir araç seçin.")]
        public int CarId { get; set; }
        public virtual AppUser? User { get; set; }
        public int? UserId { get; set; }

    }
}
