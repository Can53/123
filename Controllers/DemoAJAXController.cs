using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
namespace MVCAJAX.Controllers
{
    public class DemoAJAXController : Controller
    {

        public ActionResult  GetRows()
        {
            return Json(StudentManager.GetRows(), JsonRequestBehavior.AllowGet) ;
        }
            // GET: DemoAJAX
            public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult DemoPageList(int pageindex,int pagesize)
        {
            return Json(StudentManager.PageListDemo(pageindex,pagesize),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Del(int id)
        {
            return Json(StudentManager.Del(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(students s)
        {
            return Json(StudentManager.Add(s), JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetClasses()
        {
            return Json(ClassesManager.GetClasses(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(students s)
        {
            return Json(StudentManager.Edit(s), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetById(int id)
        {
            return Json(StudentManager.GetById(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update()
        {
            return View();
        }

    }
}