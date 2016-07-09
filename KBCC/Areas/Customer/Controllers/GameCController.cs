using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBCC.Areas.Customer.Controllers
{
    [CheckCustomer]
    public class GameCController : Controller
    {
        // GET: Customer/GameC
        public ActionResult Index()
        {
            return View();
        }
    }
}