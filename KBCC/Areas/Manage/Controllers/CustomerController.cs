using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KB.Models;
using KB.BLL;

namespace KBCC.Areas.Manage.Controllers
{

    [CheckAdmin]
    public class CustomerController : Controller
    {
        // GET: Manage/Customer
        public ActionResult Index()
        {
            IQueryable<tb_Game> game =new GameService().FindList(0);
            string s = ",";
            foreach(var i in game)
            {
               s=s+ i.GName+",";
            }
            ViewBag.GList = s;
            IQueryable<tb_Admin> Admin = new AdminService().FindList(0);
            return View(Admin);
        }
        [HttpPost]
        public ActionResult AddCustomer(tb_Admin Admin)
        {
            try
            {
                Admin.GetGame = "0";
                new AdminService().Add(Admin);

                return Content("ok: 添加成功！");
            }
            catch
            {
                return Content("no: 输入有误，添加失败！");
            }
        }
        [HttpPost]
        public ActionResult Delete(int AdID)
        {
            tb_Admin Ad = new AdminService().Find(AdID);
            bool delte = new AdminService().Delete(Ad);
            if (delte)
            {
                TempData["message"] = string.Format("{0} 已删除", Ad.AdName);
            }
            else
            {
                TempData["message"] = string.Format("{0} 删除失败", Ad.AdName);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int AdID)
        {
            tb_Admin admin = new AdminService().Find(AdID);
            return View(admin);
        }
        [HttpPost]
        public ActionResult Edit(tb_Admin model)
        {
            if (ModelState.IsValid)
            {
                new AdminService().Update(model);
                TempData["message"] = string.Format("{0} 已经被保存", model.AdName);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = string.Format("{0} 修改失败", model.AdName);
                return View(model);
            }

        }
        public ActionResult AuthGame(int AdID)
        {
            tb_Admin admin = new AdminService().Find(AdID);
            return View(admin);
        }
        [HttpPost]
        public ActionResult AuthGame(int AdID,string gamelist)
        {
             tb_Admin admin = new AdminService().Find(AdID);
            if (gamelist != null&&gamelist!="")
            {
               gamelist = gamelist.Remove(gamelist.LastIndexOf(","), 1);
               admin.GetGame = gamelist;
               new AdminService().Update(admin);
            }
            tb_Admin admin2 = new AdminService().Find(AdID);
            
            return View(admin2);
        }
    }
}