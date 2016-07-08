using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBCC.Areas.Manage.Controllers
{
    
    [CheckAdmin]
    public class MemberController : Controller
    {
        // GET: Manage/Member
        public ActionResult Index()
        {
            return View();
        }
    }
}