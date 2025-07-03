using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concrete
{
    public class DashboardManager(IDashboardDal _dashboardDal) : IDashboardService
    {
        public int ApprovedBookingCount()
        {
            return _dashboardDal.ApprovedBookingCount();
        }

        public int DeclineBookingCount()
        {
            return _dashboardDal.DeclineBookingCount();
        }

        public List<Booking> GetBookings()
        {
            return _dashboardDal.GetBookings();
        }

        public List<Message> GetMessages()
        {
            return _dashboardDal.GetMessages();
        }

        public double GetTestimonialAvarage()
        {
            return _dashboardDal.GetTestimonialAvarage();
        }

        public List<Testimonial> GetTestimonials()
        {
            return _dashboardDal.GetTestimonials();
        }

        public List<Car> LastAddedCars()
        {
            return _dashboardDal.LastAddedCars();
        }

        public int TotalBookingCount()
        {
            return _dashboardDal.TotalBookingCount();
        }

        public int TotalBrandCount()
        {
            return _dashboardDal.TotalBrandCount();
        }

        public int TotalCarCount()
        {
            return _dashboardDal.TotalCarCount();
        }

        public int TotalManagerCount()
        {
            return _dashboardDal.TotalManagerCount();
        }

        public int TotalMessageCount()
        {
            return _dashboardDal.TotalMessageCount();
        }

        public int TotalReviewCount()
        {
            return _dashboardDal.TotalReviewCount();
        }

        public int TotalTestimonialCount()
        {
            return _dashboardDal.TotalTestimonialCount();
        }

        public int TotalUserCount()
        {
            return _dashboardDal.TotalUserCount();
        }

        public int WaitingBookingCount()
        {
            return _dashboardDal.WaitingBookingCount();
        }
    }
}
