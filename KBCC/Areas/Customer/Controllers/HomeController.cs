using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KB.Models;
using KB.BLL;

namespace KBCC.Areas.Customer.Controllers
{
    [CheckCustomer]
    public class HomeController : Controller
    { 
        // GET: Customer/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserManage()
        {
            int AdID = Convert.ToInt32(Session["UID"]);
            IQueryable<tb_User> User = new UserService().FindList(0,AdID);
            return View(User);
        }
        [HttpPost]
        public ActionResult Delete(int UsID)
        {
            tb_User us = new UserService().Find(UsID);
            bool delte= new UserService().Delete(us);
            if (delte)
            {

                TempData["message"] = string.Format("{0} 已删除", us.UsName);
            }
            return RedirectToAction("UserManage");
        }
        [HttpPost]
        public ActionResult AddUser(tb_User user)
        {
            int AdID = Convert.ToInt32(Session["UID"]);
            bool Bool = new UserService().Exist(user.UsName);
            user.AdID = AdID;
            if (ModelState.IsValid&&!Bool)
            {
                TempData["message"] = string.Format("{0} 已经被保存", user.UsName);
                new UserService().Add(user);
                return RedirectToAction("UserManage");
            }
            else
            {
                TempData["message"] = string.Format("{0}输入有误或用户名已存在！", user.UsName);
                return RedirectToAction("UserManage");
            }
            
        }
        [HttpPost]
        public ActionResult EditMe(tb_Admin model)
        {
            bool Bool = new AdminService().Exist(model.AdID);
            if (ModelState.IsValid)
            {
                //new AdminService().Update(model);
                new AdminService().EditMe(model);
                tb_EditCent MyCent = new EditCentService().Find(model.AdID);
                tb_EditCent MyCent2 = new tb_EditCent();
                try
                {
                    if (MyCent.AfterCent != model.CentNum)
                    {
                        MyCent2.BeforeCent = MyCent.AfterCent;
                        MyCent2.AfterCent = model.CentNum;
                        MyCent2.AdID = model.AdID;
                        MyCent2.AddTime = DateTime.Now;
                        new EditCentService().Add(MyCent2);
                    }
                }
                catch
                {
                        MyCent2.BeforeCent = 0;
                        MyCent2.AfterCent = model.CentNum;
                        MyCent2.AdID = model.AdID;
                        MyCent2.AddTime = DateTime.Now;
                        new EditCentService().Add(MyCent2);
                }
              
                TempData["message"] = string.Format("{0} 已经被保存", model.AdName);
                return View(model);
            }
            else
            {
                TempData["message"] = string.Format("{0}修改失败！", model.AdName);
                return View(model);
            }
        }
        public ActionResult EditMe()
        {
            int AdID = int.Parse(Session["UID"].ToString());
            tb_Admin Admin = new AdminService().Find(AdID);
            return View(Admin);
        }

    }
}