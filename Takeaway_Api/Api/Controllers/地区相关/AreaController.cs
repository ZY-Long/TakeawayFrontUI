using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using SDK;

namespace Api.Controllers
{
    /// <summary>
    /// 地区相关控制器
    /// </summary>
    public class AreaController : ApiController
    {
        /// <summary>
        /// 获取地区集合
        /// </summary>
        /// <param name="cityRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public AreaResponse GetArealnfos(AreaRequest areaRequest)
        {
            if (areaRequest.cityId <= 0)
            {
                areaRequest.cityId = 0;
            }
            AreaResponse response = new AreaResponse();
            response.Arealnfos = BaseBLL<AreaBLL>.Instance.GetArealnfos(areaRequest.cityId);
            return response;
        }
    }
}
