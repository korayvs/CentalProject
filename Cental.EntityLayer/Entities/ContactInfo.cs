using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class ContactInfo : BaseEntity
    {
        public int ContactInfoId { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public string SocialMedia3 { get; set; }
        public string SocialMedia4 { get; set; }
        public string OpeningHours { get; set; }
        public string ClosingHours { get; set; }
    }
}
