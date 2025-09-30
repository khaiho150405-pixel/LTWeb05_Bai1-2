using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTWeb05_Bai01.Models
{
    public class DepartmentViewModel
    {
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; }   
    }

}