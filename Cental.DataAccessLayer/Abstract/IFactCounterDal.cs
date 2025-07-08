using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccessLayer.Abstract
{
    public interface IFactCounterDal
    {
        int UserCount();
        int CarCount();
        int BookingCount();
        int ReviewCount();
    }
}
