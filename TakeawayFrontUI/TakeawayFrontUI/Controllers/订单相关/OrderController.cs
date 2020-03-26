using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDK;
using BLL;

namespace TakeawayFrontUI.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL bll = new OrderBLL();

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        

        /// <summary>
        /// 生成订单信息
        /// </summary>
        public JsonResult GenerateOrder(GenerateOrderRequest areaRequest)
        {
            return Json(bll.GenerateOrder(areaRequest));
        }
    }
}