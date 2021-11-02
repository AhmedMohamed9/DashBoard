using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.dal.Entity
{
    
   public class Employee
    {
       
        public int id { get; set; }
        [Required,MaxLength(50)]
        public string name { get; set; }
        [Required]
        public double salary { get; set; }
        public DateTime hiredate { get; set; }

        public DateTime CreationDate { get; set; }

        public bool isActive { get; set; }
        public string notes { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public int departmentid { get; set; }
        [ForeignKey("departmentid")]
        public Department department { get; set; }


    }
}
