using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDK;

namespace TakeawayFrontUI.Controllers
{
    public class UserController : Controller
    {
        UserBll userBll = new UserBll();
        // 注册页面
        public ActionResult Index()
        {

            return View();
        }

        ///// <summary>
        ///// 用户注册
        ///// </summary>
        //public JsonResult UerRegist(UserAddRequest userAddRequest)
        //{
        //    //get请求
        //    //return Json(userBll.AddUser(userAddRequest), JsonRequestBehavior.AllowGet);

        //    return Json(userBll.AddUser(userAddRequest));
        //}

    }
}