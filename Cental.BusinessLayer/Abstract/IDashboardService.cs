using Cental.DataAccessLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Abstract
{
    public interface IDashboardService
    {
        int TTotalUserCount();
        int TTotalManagerCount();
        int TTotalAdminCount();
        int TTotalMessageCount();
        int TTotalCarCount();
        int TTotalTestimonialCount();
        int TTotalReviewCount();
        int TTotalBrandCount();
        int TTotalBookingCount();
        int TWaitingBookingCount();
        int TApprovedBookingCount();
        int TDeclineBookingCount();
        double TGetTestimonialAvarage();
        int TMostExpensiveCar();
        int TMostCheapCar();
        string TMostSelectedCarName();
        string TLeastSelectedCarName();
        List<Booking> TGetBookings();
        List<Car> TLastAddedCars();
        List<Message> TGetMessages();
        List<Testimonial> TGetTestimonials();
    }
}
