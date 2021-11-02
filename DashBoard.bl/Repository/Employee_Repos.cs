using DashBoard.bl.interfaces;
using DashBoard.dal.database;
using DashBoard.dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.bl.Repository
{
    public class IEmployee_Repos : IEmployee_Rep
    {

        private readonly Context db;

        public IEmployee_Repos(Context db) 
        {
            this.db = db;
        }

        public IEnumerable<Employee> get()
        {
            return (db.employees.Include(q=>q.department));
        }

        public Employee getbyid(int id)
        {
            return (db.employees.Where(s => s.id == id).FirstOrDefault()); 
        }

        public void create(Employee obj)
        {
            db.employees.Add(obj);
            db.SaveChanges();
        }

        public void delete(Employee dep)
        {
            db.Remove(dep);
            db.SaveChanges();
        }

        public void edit(Employee obj)
        {
            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

       
    }
}
