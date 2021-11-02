using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoard.dal.Entity;

namespace DashBoard.bl.ViewModel
{
  public  class DepartmentVM
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MinLength(3, ErrorMessage = "min is 3 letters")]
        [StringLength(50)]
       
        public string name { get; set; }
        [Required]
        public string depCode { get; set; }

       
    }
}
