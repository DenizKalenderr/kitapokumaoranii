using DataAccessLayer.Concrate;
using EntityLaye.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Sehir.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult AdminGiris()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult AdminGiris(Admin p)
        {
            Context c = new Context();

            var admininfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.UserName, false); //yetkilendirme
                Session["UserName"] = admininfo.UserName.ToString();
                return RedirectToAction("AdminList", "Ekle");
            }
            else
            {
                return RedirectToAction("AdminGiris", "Login");

            }
        }
    }
}