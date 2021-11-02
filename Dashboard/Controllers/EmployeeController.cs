using AutoMapper;
using DashBoard.bl.interfaces;
using DashBoard.bl.Repository;
using DashBoard.bl.ViewModel;
using DashBoard.dal.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee_Rep emp;
        private readonly IMapper map;
        private readonly IDepartmentRep<Department> dep;

        public EmployeeController(IEmployee_Rep emp,IMapper map,IDepartmentRep<Department> dep)
        {
            this.emp = emp;
            this.map = map;
            this.dep = dep;
        }
        public IActionResult Index()
        {
            var data= emp.get();
            var model = map.Map<IEnumerable<employeeVM>>(data);
            return View(model);
        }
        public IActionResult create()
        {
            ViewBag.department =new SelectList(dep.get(),"id","name");
            return View();
        }
        [HttpPost]
        public IActionResult create(employeeVM obj)
        {
            var model = map.Map<Employee>(obj);
            emp.create(model);
          return  RedirectToAction("index");
        }
        public IActionResult edit(int id)
        {
           
            var model = emp.getbyid(id);
            var data = map.Map<employeeVM>(model);
            ViewBag.department = new SelectList(dep.get(), "id", "name",model.departmentid);
            return View(data);
        }
        [HttpPost]
        public IActionResult edit(employeeVM departs)
        {
            if (ModelState.IsValid)
            {
                var data = map.Map<Employee>(departs);
                emp.edit(data);
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.department = new SelectList(dep.get(), "id", "name", departs.departmentid);
                return View(dep);
            }
         
        }
        public IActionResult delete(int id)
        {
            var model = emp.getbyid(id);
            var data = map.Map<employeeVM>(model);
            return View(data);

        }
        [HttpPost]
        public IActionResult delete(DepartmentVM dep)
        {
            var data = map.Map<Employee>(dep);
            emp.delete(data);
            return RedirectToAction("index");
        }
    }
}
