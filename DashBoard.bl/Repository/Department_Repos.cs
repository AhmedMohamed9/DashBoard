using DashBoard.bl.interfaces;
using DashBoard.bl.ViewModel;
using DashBoard.dal.database;
using DashBoard.dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.bl.Repository
{
   public class Department_Repos : IDepartmentRep<Department>
    {
        private readonly Context db;

        public Department_Repos(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Department> get()
        {
            List<Department> data = getall();
            return (data);

        }

        private List<Department> getall()
        {
            return db.departments.Select(a => a).ToList();
        }

        public Department getbyid(int id)
        {
            var dep = db.departments.Where(a =>a.id==id);
            return (dep.FirstOrDefault());
        }
        public void create(Department obj)
        {
            db.departments.Add(obj);
            db.SaveChanges();
        }

        public void delete(Department dep)
        {
           
            db.Remove(dep);
            db.SaveChanges();
        }

        public void edit(Department obj)
        {

            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

       
    }
}
