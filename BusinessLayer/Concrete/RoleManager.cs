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
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public void TInsert(Role t)
        {
            _roleDal.Insert(t);
        }

        public void TDelete(Role t)
        {
            _roleDal.Delete(t);
        }

        public void TUpdate(Role t)
        {
            _roleDal.Update(t);
        }

        public List<Role> TGetListAll()
        {
            return _roleDal.GetListAll();
        }

        public Role TGetByID(int id)
        {
            return _roleDal.GetByID(id);
        }
    }
}
