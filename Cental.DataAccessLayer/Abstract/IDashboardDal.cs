using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Abstract
{
    public interface IDashboardDal
    {
        int TotalUserCount();
        int TotalManagerCount();
        int TotalAdminCount();
        int TotalMessageCount();
        int TotalCarCount();
        int TotalTestimonialCount();
        int TotalReviewCount();
        int TotalBrandCount();
        int TotalBookingCount();
        int WaitingBookingCount();
        int ApprovedBookingCount();
        int DeclineBookingCount();
        double GetTestimonialAvarage();
        int MostExpensiveCar();
        int MostCheapCar();
        string MostSelectedCarName();
        string LeastSelectedCarName();
        List<Booking> GetBookings();
        List<Car> LastAddedCars();
        List<Message> GetMessages();
        List<Testimonial> GetTestimonials();
    }
}
