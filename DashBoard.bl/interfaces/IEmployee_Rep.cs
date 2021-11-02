using DashBoard.dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.bl.interfaces
{
   public interface IEmployee_Rep
    {
        IEnumerable<Employee> get();
        Employee getbyid(int id);
        void create(Employee obj);
        void edit(Employee obj);
        void delete(Employee dep);
    }
}
