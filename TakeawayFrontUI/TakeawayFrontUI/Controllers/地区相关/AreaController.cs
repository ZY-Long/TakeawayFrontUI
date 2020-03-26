using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDK;
using BLL;

namespace TakeawayFrontUI.Controllers
{
    public class AreaController : Controller
    {
        AreaBLL bll = new AreaBLL();

        // GET: Area
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取地区集合
        /// </summary>
        public JsonResult GetArealnfos(AreaRequest areaRequest)
        {
            return Json(bll.GetArealnfos(areaRequest));
        }
    }
}