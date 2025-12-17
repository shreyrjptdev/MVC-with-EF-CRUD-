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
        public ActionResult Index(int a = 0)
        {
            ViewBag.st = dbo.tblStates.ToList();
            ViewBag.ge = dbo.tblGenders.ToList();
            ViewBag.btn = "Save";
            tblStudent obj = new tblStudent();
            if (a > 0)
            {
                var data = (from d in dbo.tblStudents where d.id == a select d).ToList();
                obj.id = data[0].id;
                obj.name = data[0].name;
                obj.age = data[0].age;
                obj.state = data[0].state;
                obj.city = data[0].city;
                obj.gender = data[0].gender;
                ViewBag.btn = "Update";
            }
            ViewBag.ct = dbo.tblCities.Where(x => x.sid == obj.state).ToList();
            return View(obj);
        }

        public ActionResult Show(int a = 0)
        {
            var data = (from s in dbo.tblStudents 
                        join st in dbo.tblStates on s.state equals st.sid
                        join c in dbo.tblCities on s.city equals c.cid
                        join g in dbo.tblGenders on s.gender equals g.gid
                        select new tblshow
                        {
                            id = s.id,
                            name = s.name,
                            age = s.age,
                            state = st.sname,
                            city = c.cname,
                            gender = g.gname
                        } ).ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult insertupdate(tblStudent obj)
        {
            if (obj.id > 0)
            {
                dbo.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                dbo.tblStudents.Add(obj);
            }
            dbo.SaveChanges();
            return RedirectToAction("Show");
        }

        public ActionResult delete(int a = 0)
        {
            dbo.tblStudents.Remove(dbo.tblStudents.Find(a));
            dbo.SaveChanges();
            return RedirectToAction("Show");
        }
        public JsonResult getcity(int sid = 0)
        {
            var data = dbo.tblCities.Where(x => x.sid == sid).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}