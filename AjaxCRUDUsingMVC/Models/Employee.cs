using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxCRUDUsingMVC.Models
{

    [Table("emp", Schema = "public")]
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; } 
        public string email { get; set; }
        public int salary { get; set; }
        public string  managername { get; set; }
        public long telephonenumber { get; set; }



    }


}