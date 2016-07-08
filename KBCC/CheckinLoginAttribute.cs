using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KB.Models;
using KB.BLL;

namespace KBCC
{
    //最高权限
    public class CheckRedBullAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string UID = filterContext.HttpContext.Session["UID"].ToString();
                string pwd = filterContext.HttpContext.Session["PWD"].ToString();
                tb_Root root = new RootService().Find(UID, pwd);
                if (root.RoID != 1)
                {
                    filterContext.HttpContext.Response.Redirect("/Manage/Home");
                }
            }
            catch
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }

        }
    }
    //网站管理员权限
    public class CheckAdminAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string UID = filterContext.HttpContext.Session["UID"].ToString();
                string pwd = filterContext.HttpContext.Session["PWD"].ToString();
                bool root = new RootService().Exist(UID, pwd);
                if (!root)
                {
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
            catch
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
            
        }
    }
    //客户权限
    public class CheckCustomerAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string UID = filterContext.HttpContext.Session["UID"].ToString();
                string pwd = filterContext.HttpContext.Session["PWD"].ToString();
                bool Customer = new AdminService().Exist(UID, pwd);
                if (!Customer)
                {
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
            catch
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
            
        }
    }
    //用户权限
    public class CheckUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                string UID = filterContext.HttpContext.Session["UID"].ToString();
                string pwd = filterContext.HttpContext.Session["PWD"].ToString();
                bool user = new UserService().Exist(UID, pwd);
                if (!user)
                {
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
            catch
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
            
        }
    }
    
    
}