using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBCC.Areas.Manage.Controllers
{
    
    [CheckAdmin]
    public class FinanceController : Controller
    {
        // GET: Manage/Finance
        public ActionResult Index()
        {
            return View();
        }
    }
}