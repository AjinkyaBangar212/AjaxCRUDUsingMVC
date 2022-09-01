using AjaxCRUDUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxCRUDUsingMVC.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController()
        {
            _context = new Context();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(_context.empobj.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Employee user)
        {
            _context.empobj.Add(user);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(int ID)
        {
            return Json(_context.empobj.FirstOrDefault(x => x.empid == ID), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Employee user)
        {
         
            var data = _context.empobj.FirstOrDefault(x => x.empid == user.empid);
            if (data != null)
            {
                data.empname = user.empname;
                data.email = user.email;
                data.salary = user.salary;
                data.managername = user.managername;
                data.telephonenumber = user.telephonenumber;
               
                _context.SaveChanges();
            }
            return Json(JsonRequestBehavior.AllowGet);
        }


        public JsonResult Delete(int ID)
        {
            var data = _context.empobj.FirstOrDefault(x => x.empid == ID);
            _context.empobj.Remove(data);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}