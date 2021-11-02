using AutoMapper;
using DashBoard.bl.interfaces;
using DashBoard.bl.Repository;
using DashBoard.bl.ViewModel;
using DashBoard.dal.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

 
namespace Dashboard.Controllers
{
    public class DepartmentController : Controller
    {
        //lossely coupled
        private readonly IDepartmentRep<Department>  department;
        private readonly IMapper mapper;

        public DepartmentController(IDepartmentRep<Department> _department,IMapper mapper)
        {
            department = _department;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var data = department.get();
            var model = mapper.Map<IEnumerable<DepartmentVM>>(data);
            return View(model);
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(DepartmentVM dep)
        {
            if (ModelState.IsValid==true)
            {
                var model = mapper.Map<Department>(dep);
                department.create(model);
                return RedirectToAction("index");
            } 
            else
            {
                return View(dep);
            }
      
        }
        public IActionResult edit(int id)
        {
            var model = department.getbyid(id);
            var data = mapper.Map<DepartmentVM>(model);
            return View(data);
        }
        [HttpPost]
        public IActionResult edit(DepartmentVM dep)
        {
            var data = mapper.Map<Department>(dep);
            department.edit(data);
            return RedirectToAction("index");
        }
        public IActionResult delete(int id)
        {
            var model = department.getbyid(id);
            var data = mapper.Map<DepartmentVM>(model);
            return View(data);

        }
        [HttpPost]
        public IActionResult delete(DepartmentVM dep)
        {
          var data=  mapper.Map<Department>(dep);
            department.delete(data);
            return RedirectToAction("index");
        }
    }

}
