using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDK;
using BLL;

namespace TakeawayFrontUI.Controllers
{
    public class CityController : Controller
    {
        CityBLL bll = new CityBLL();

        // GET: Area
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取城市集合
        /// </summary>
        public JsonResult GetCityInfos(CityRequest cityRequest)
        {
            return Json(bll.GetCityInfos(cityRequest));
        }
    }
}