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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }

        public List<Customer> TGetListAll()
        {
            return _customerDal.GetListAll();
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }
    }
}
