using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.BookingDtos
{
    public class CreateBookingDto
    {
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public bool? IsApproved { get; set; }
        public string Status { get; set; }
        public int CarId { get; set; }
        public virtual AppUser? User { get; set; }
        public int? UserId { get; set; }
    }
}
