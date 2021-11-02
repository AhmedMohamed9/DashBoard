using DashBoard.dal.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.bl.ViewModel
{
   public class employeeVM
    {
        public employeeVM()
        {
            this.CreationDate = DateTime.Now;
        }


        public int id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MinLength(3, ErrorMessage = "min is 3 letters")]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [Range(1000,10000,ErrorMessage ="range is from 1000 to 10000")] 
        public double salary { get; set; }
        public DateTime hiredate { get; set; }

        public DateTime CreationDate { get; set; }

        public bool isActive { get; set; }
        public string notes { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage ="choose department")]
        public int departmentid { get; set; }
        [ForeignKey("departmentid")]
        public Department department { get; set; }
    }
}
