using MVC_with_EF__CRUD_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_with_EF__CRUD_.Controllers
{
    public class DefaultController : Controller
    {
        db dbo = new db();
        public ActionResult Index()
        {
            ViewBag.state = dbo.tblStates.ToList();
            ViewBag.gender = dbo.tblGenders.ToList();
            ViewBag.data = dbo.tblStudents.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult insert(tblStudent obj)
        {
            dbo.tblStudents.Add(obj);
            dbo.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}