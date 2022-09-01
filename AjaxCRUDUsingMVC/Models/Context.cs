using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxCRUDUsingMVC.Models
{
    public class Context:DbContext
    {

        public Context() : base("Myconnection")
        { }
        public DbSet<Employee> empobj  { get; set; }


    }
}