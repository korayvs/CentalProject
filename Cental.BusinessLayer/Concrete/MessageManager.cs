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
    public class MessageManager(IMessageDal _messageDal) : IMessageService
    {
        public void TCreate(Message entity)
        {
            _messageDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _messageDal.Delete(id);
        }

        public List<Message> TGetAll()
        {
            return _messageDal.GetAll();
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
