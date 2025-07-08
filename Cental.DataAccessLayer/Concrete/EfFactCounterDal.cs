using Cental.DataAccessLayer.Abstract;
using Cental.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Concrete
{
    public class EfFactCounterDal : IFactCounterDal
    {
        protected readonly CentalContext _context;

        public EfFactCounterDal(CentalContext context)
        {
            _context = context;
        }

        public int BookingCount()
        {
            return _context.Bookings.Count();
        }

        public int CarCount()
        {
            return _context.Cars.Count();
        }

        public int ReviewCount()
        {
            return _context.Reviews.Count();
        }

        public int UserCount()
        {
            return _context.Users.Count();
        }
    }
}
