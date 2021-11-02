using DashBoard.bl.ViewModel;
using DashBoard.dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.bl.interfaces
{ 
    public interface IDepartmentRep<t>
{
        IEnumerable<t> get();
        t getbyid(int id);
        void create(t obj);
        void edit(t obj);
        void delete(t dep);

}
}
