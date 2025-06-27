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
    public class ContactInfoManager(IContactInfoDal _contactInfoDal) : IContactInfoService
    {
        public void TCreate(ContactInfo entity)
        {
            _contactInfoDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _contactInfoDal.Delete(id);
        }

        public List<ContactInfo> TGetAll()
        {
            return _contactInfoDal.GetAll();
        }

        public ContactInfo TGetById(int id)
        {
            return _contactInfoDal.GetById(id);
        }

        public void TUpdate(ContactInfo entity)
        {
            _contactInfoDal.Update(entity);
        }
    }
}
