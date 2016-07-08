using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBCC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            string UID = Request["UID"];
            string UserPwd = Request["PWD"];
            bool isro = false;
            bool isma = false;
            bool isus = false;
            isus = new KB.BLL.UserService().Exist(UID, UserPwd);            
            isma= new KB.BLL.AdminService().Exist(UID,UserPwd);
            isro = new KB.BLL.RootService().Exist(UID, UserPwd);
            if (isus)
            {
                Session["UID"] = UID;
                Session["PWD"] = UserPwd;
                if (Request["Remember"] != "false")
                {
                    HttpCookie cookie = new HttpCookie("KKKWCook");
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new TimeSpan(30,0, 0, 0, 0);//过期时间为30天
                    cookie.Expires = dt.Add(ts);//设置过期时间
                    cookie.Values.Add("UID", UID);
                    cookie.Values.Add("PWD", UserPwd);
                    Response.AppendCookie(cookie);
                }
                return Content("ok:登陆成功！:"+ "/Home/Index");  
            }
            else if (isma)
            {
                Session["UID"] = UID;
                Session["PWD"] = UserPwd;
                if (Request["Remember"] != "false")
                {
                    HttpCookie cookie = new HttpCookie("KKKWCook");
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new TimeSpan(30, 0, 0, 0, 0);//过期时间为30天
                    cookie.Expires = dt.Add(ts);//设置过期时间
                    cookie.Values.Add("UID", UID);
                    cookie.Values.Add("PWD", UserPwd);
                    Response.AppendCookie(cookie);

                }
                return Content("ok:登陆成功！:" + "/Customer/Home/Index");
            }
            else if (isro)
            {
                Session["UID"] = UID;
                Session["PWD"] = UserPwd;
                if (Request["Remember"] != "false")
                {
                    HttpCookie cookie = new HttpCookie("KKKWCook");
                    DateTime dt = DateTime.Now;
                    TimeSpan ts = new TimeSpan(30, 0, 0, 0, 0);//过期时间为30天
                    cookie.Expires = dt.Add(ts);//设置过期时间
                    cookie.Values.Add("UID", UID);
                    cookie.Values.Add("PWD", UserPwd);
                    Response.AppendCookie(cookie);

                }
                return Content("ok:登陆成功！:" + "/Manage/Home/Index");
            }
            else
            {
                return Content("no:登录失败！");
            }

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Response.Redirect("/Login");
            return View();
        }
    }
}