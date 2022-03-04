using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
   public class MessageManager : IMessageServis
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }


        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSenbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            //_messageDal.Insert(message);
            throw new NotImplementedException();
        }

        public void MessageDelete(Message message)
        {
            //_messageDal.Delete(message);
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            //_messageDal.Update(message);
            throw new NotImplementedException();
        }
    }
}
