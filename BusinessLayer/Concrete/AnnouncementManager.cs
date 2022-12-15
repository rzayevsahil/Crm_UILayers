using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TInsert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }

        public List<Announcement> TGetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public Announcement TGetByID(int id)
        {
            return _announcementDal.GetByID(id);
        }
    }
}
