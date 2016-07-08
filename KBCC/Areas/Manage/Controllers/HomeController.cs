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
    public class HomeController : Controller
    {
        // GET: Manage/Home
        public ActionResult Index()
        {
            return View();
        }
        //账号管理
        [CheckRedBull]
        public ActionResult Account()
        {
            IQueryable<tb_Root> roo = new RootService().FindList(0);
            
            foreach(var c in roo)
            {
                ViewBag.CC=c.RoID;
            }
            
            return View();
        }
        [HttpPost]
        [CheckRedBull]
        public ActionResult Delete(int RoID)
        {
            tb_Root Ro = new RootService().FindID(RoID);
            bool delte = new RootService().Delete(Ro);
            if (delte)
            {

                TempData["message"] = string.Format("{0} 已删除", Ro.RoName);
            }
            return RedirectToAction("Account");
        }
        [HttpPost]
        [CheckRedBull]
        public ActionResult AddAccount(tb_Root model)
        {
            bool Bool = new RootService().Exist(model.RoName);
            if (Bool)
            {
                return Content("no:账号已存在！");
            }
            try
            {
                new RootService().Add(model);
                return Content("ok: 添加成功！");
            }
            catch
            {
                return Content("no: 输入有误，添加失败！");
            }
            
        }
        [HttpPost]
        public ActionResult Message(tb_Root model)
        {
            bool Bool = new RootService().Exist(model.RoName);
            if (ModelState.IsValid)
            {
                new RootService().Update(model);
                TempData["message"] = string.Format("{0} 已经被保存", model.RoName);
                return RedirectToAction("Account");
            }
            else
            {
                TempData["message"] = string.Format("{0} 该名称的账号已存在或名称未变", model.RoName);
                return View(model);
            }

        }
        public ActionResult Message(int RoID)
        {
            
            tb_Root root = new RootService().FindID(RoID);
            return View(root);
        }
    }
}