using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetReceiverMessageList(string mail)
        {
            Context context = new Context();
            return context.Messages.Where(x => x.ReceiverMail == mail).ToList();
        }

        public List<Message> GetSenderMessageList(string mail)
        {
            Context context = new Context();
            return context.Messages.Where(x => x.SenderMail == mail).ToList();
        }
    }
}
