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
        public int TApprovedBookingCount()
        {
            return _dashboardDal.ApprovedBookingCount();
        }

        public int TDeclineBookingCount()
        {
            return _dashboardDal.DeclineBookingCount();
        }

        public List<Booking> TGetBookings()
        {
            return _dashboardDal.GetBookings();
        }

        public List<Message> TGetMessages()
        {
            return _dashboardDal.GetMessages();
        }

        public double TGetTestimonialAvarage()
        {
            return _dashboardDal.GetTestimonialAvarage();
        }

        public List<Testimonial> TGetTestimonials()
        {
            return _dashboardDal.GetTestimonials();
        }

        public List<Car> TLastAddedCars()
        {
            return _dashboardDal.LastAddedCars();
        }

        public string TLeastSelectedCarName()
        {
            return _dashboardDal.LeastSelectedCarName();
        }

        public int TMostCheapCar()
        {
            return _dashboardDal.MostCheapCar();
        }

        public int TMostExpensiveCar()
        {
            return _dashboardDal.MostExpensiveCar();
        }

        public string TMostSelectedCarName()
        {
            return _dashboardDal.MostSelectedCarName();
        }

        public int TTotalBookingCount()
        {
            return _dashboardDal.TotalBookingCount();
        }

        public int TTotalBrandCount()
        {
            return _dashboardDal.TotalBrandCount();
        }

        public int TTotalCarCount()
        {
            return _dashboardDal.TotalCarCount();
        }

        public int TTotalManagerCount()
        {
            return _dashboardDal.TotalManagerCount();
        }

        public int TTotalMessageCount()
        {
            return _dashboardDal.TotalMessageCount();
        }

        public int TTotalReviewCount()
        {
            return _dashboardDal.TotalReviewCount();
        }

        public int TTotalTestimonialCount()
        {
            return _dashboardDal.TotalTestimonialCount();
        }

        public int TTotalUserCount()
        {
            return _dashboardDal.TotalUserCount();
        }

        public int TWaitingBookingCount()
        {
            return _dashboardDal.WaitingBookingCount();
        }
    }
}
