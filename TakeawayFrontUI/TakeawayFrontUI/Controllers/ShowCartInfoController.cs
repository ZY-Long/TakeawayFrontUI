using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDK;

namespace TakeawayFrontUI.Controllers
{
    public class ShowCartInfoController : Controller
    {
        UserBLL bll = new UserBLL();
        // GET: ShowCartInfo
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetTake(TakeRequest request)
        {
            return Json(bll.GetTake(request));
        }
        /// <summary>
        /// 显示购物车
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetCart(GetCartRequest request)
        {
            return Json(bll.GetCart(request), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult DeleteCart(DeleteCartRequest request)
        {
            return Json(bll.DeleteCart(request));
        }
    }
}