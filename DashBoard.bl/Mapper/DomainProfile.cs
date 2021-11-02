using AutoMapper;
using DashBoard.bl.ViewModel;
using DashBoard.dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace DashBoard.bl.Mapper
{
   public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Department, DepartmentVM>();
            CreateMap<DepartmentVM, Department>();
            
            CreateMap<Employee , employeeVM>();
            CreateMap<employeeVM, Employee>();
        }
    }
}
