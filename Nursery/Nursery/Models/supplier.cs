using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nursery.Models
{
    public class supplier
    {

        [Key]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string SupplierAddress { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public int SupplierPhone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        //[RegularExpression(@*)]
        [DataType(DataType.EmailAddress)]
        public string SupplierEmail { get; set; }
    }
}