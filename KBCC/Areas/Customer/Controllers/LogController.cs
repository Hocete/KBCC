using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBCC.Areas.Customer.Controllers
{
    [CheckCustomer]
    public class LogController : Controller
    {
        // GET: Customer/Log
        public ActionResult Index()
        {
            return View();
        }
    }
}