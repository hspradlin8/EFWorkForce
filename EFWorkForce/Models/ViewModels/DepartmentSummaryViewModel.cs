using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkForce.Models.ViewModels
{
    public class DepartmentSummaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public int EmployeeCount { get; set; }
   
    }

}

