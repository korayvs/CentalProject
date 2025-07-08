using Cental.BusinessLayer.Abstract;
using Cental.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concrete
{
    public class FactCounterManager(IFactCounterDal _factCounterDal) : IFactCounterService
    {
        public int TBookingCount()
        {
            return _factCounterDal.BookingCount();
        }

        public int TCarCount()
        {
            return _factCounterDal.CarCount();
        }

        public int TReviewCount()
        {
            return _factCounterDal.ReviewCount();
        }

        public int TUserCount()
        {
            return _factCounterDal.UserCount();
        }
    }
}
