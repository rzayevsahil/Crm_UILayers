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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void TInsert(Employee t)
        {
            _employeeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _employeeDal.Delete(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }

        public List<Employee> TGetListAll()
        {
            return _employeeDal.GetListAll();
        }

        public Employee TGetByID(int id)
        {
            return _employeeDal.GetByID(id);
        }
    }
}
