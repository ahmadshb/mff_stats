using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFFStats.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("character")]
    public class CharacterController : Controller
    {
        // GET: Admin/Character
        [Route("manage")]
        public ActionResult Manage()
        {
            return View();
        }
    }
}