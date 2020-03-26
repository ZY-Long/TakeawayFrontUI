﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using log4net;
using SDK;
using Newtonsoft.Json;

namespace TakeawayFrontUI.Controllers
{
    public class UserController : Controller
    {
        UserBll userBll = new UserBll();
        // 注册页面
        public ActionResult Index()
        {
            GetProvince(new ProvinceRequest { });
            return View();
        }
        /// <summary>
        /// 下拉框显示
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetTake(TakeRequest request)
        {
            return Json(userBll.GetTake(request));
        }
        /// <summary>
        /// 显示购物车
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetCart(GetCartRequest request)
        {
            return Json(userBll.GetCart(request), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult DeleteCart(DeleteCartRequest request)
        {
            return Json(userBll.DeleteCart(request));
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

        /// <summary>
        /// 获取省份信息,用作绑定下拉框
        /// </summary>
        /// <param name="province"></param>
        /// <returns></returns>
        public JsonResult GetProvince(ProvinceRequest province)
        {
            return Json(userBll.GetProvince(province));
        }

    }
}