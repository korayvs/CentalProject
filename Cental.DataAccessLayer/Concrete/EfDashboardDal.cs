using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Context;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Concrete
{
    public class EfDashboardDal : IDashboardDal
    {
        protected readonly CentalContext _context;
        public EfDashboardDal(CentalContext context)
        {
            _context = context;
        }

        public int TotalUserCount()
        {
            return _context.Users.Count();
        }

        public int TotalManagerCount()
        {
            var managerRole = _context.Roles.Where(x => x.Name == "Manager").Select(y => y.Id).FirstOrDefault();
            return _context.UserRoles.Count(r => r.RoleId == managerRole);
        }

        public int TotalMessageCount()
        {
            return _context.Messages.Count();
        }

        public int TotalCarCount()
        {
            return _context.Cars.Count();
        }

        public int TotalTestimonialCount()
        {
            return _context.Testimonials.Count();
        }

        public int TotalReviewCount()
        {
            return _context.Reviews.Count();
        }

        public int TotalBrandCount()
        {
            return _context.Brands.Count();
        }

        public int TotalBookingCount()
        {
            return _context.Bookings.Count();
        }

        public List<Booking> GetBookings()
        {
            var bookings = _context.Bookings.OrderByDescending(x => x.BookingId).Where(y => y.IsApproved == null).Take(5).ToList();
            return bookings;
        }

        public List<Car> LastAddedCars()
        {
            var cars = _context.Cars.OrderByDescending(x => x.CarId).Take(6).ToList();
            return cars;
        }

        public List<Message> GetMessages()
        {
            return _context.Messages.ToList();
        }

        public double GetTestimonialAvarage()
        {
            var avr = _context.Testimonials.Average(x => x.Review);
            return avr;
        }

        public List<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.OrderByDescending(x => x.TestimonialId).Take(3).ToList();
        }

        public int WaitingBookingCount()
        {
            return _context.Bookings.Where(x => x.IsApproved == null).Count();
        }

        public int ApprovedBookingCount()
        {
            return _context.Bookings.Where(x => x.IsApproved == true).Count();
        }

        public int DeclineBookingCount()
        {
            return _context.Bookings.Where(x => x.IsApproved == false).Count();
        }
    }
}
