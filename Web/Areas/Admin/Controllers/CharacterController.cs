using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFFStats.Web.Areas.Admin.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Admin/Character
        public ActionResult Manage()
        {
            return View();
        }
    }
}