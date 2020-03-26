using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using SDK;

namespace TakeawayFrontUI.Controllers
{
    public class ProvinceController : Controller
    {
        ProvinceBLL bll = new ProvinceBLL();

        // GET: Area
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取地区集合
        /// </summary>
        public JsonResult GetProvinceInfos(ProvinceRequest provinceRequest)
        {
            return Json(bll.GetProvinceInfos(provinceRequest));
        }
    }
}