using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class Employer
    {
        public int EmployerId { get; set; }
        [Required]
        public string? EmployerName { get; set; }
        [Required]
        public string? EmployerPosition { get; set; }
        [Required]
        public string? EmployerDepartment { get; set; }
    }
}
