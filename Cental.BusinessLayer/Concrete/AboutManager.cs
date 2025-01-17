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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void TCreate(About entity)
        {
            _aboutdal.Create(entity);
        }

        public void TDelete(int id)
        {
            _aboutdal.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _aboutdal.GetAll();
        }

        public About TGetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public void TUpdate(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
