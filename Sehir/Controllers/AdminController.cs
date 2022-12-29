using BussinesLayer.Concrate;
using DataAccessLayer.Concrate;
using EntityLaye.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sehir.Controllers
{ 
    public class AdminController : Controller
    {
        // GET: Admin
        AdminManager am = new AdminManager();
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult AdminList()
        {
            var UserList = am.GetAll();// adminleri görüntüle
            return View(UserList);
        }
        [HttpGet] // veritabanından veri döndürmek için
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost] // göndermek için
        public ActionResult AddNew(Admin b)
        {
            am.AdminAddL(b);


            return RedirectToAction("AdminList");
        }
        public ActionResult DeleteAdmin(int id)
        {
            am.DeleteEkle(id);
            return RedirectToAction("AdminList");
        }
    }
}