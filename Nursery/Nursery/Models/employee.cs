using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nursery.Models
{
    public class employee
    {

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string EmployeeAddress { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public int EmployeePhone { get; set; }

        [Required(ErrorMessage = "this is required")]
        public string EmployeeWorkingHour { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public string EmployeeSalary { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "this is required")]
        public string EmployeeJoiningDate { get; set; }

        [DataType(DataType.Date)]
      //  [Required(ErrorMessage = "this is required")]
        public string EmployeeResigningDate { get; set; }

    }
}