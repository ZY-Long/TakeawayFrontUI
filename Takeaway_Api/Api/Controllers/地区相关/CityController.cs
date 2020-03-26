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
    /// 城市相关控制器
    /// </summary>
    public class CityController : ApiController
    {
        /// <summary>
        /// 获取城市集合
        /// </summary>
        /// <param name="cityRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public CityResponse GetCityInfos(CityRequest cityRequest)
        {
            if (cityRequest.provinceId <= 0)
            {
                cityRequest.provinceId = 0;
            }
            CityResponse response = new CityResponse();
            response.CityInfos = BaseBLL<CityBLL>.Instance.GetCityInfos(cityRequest.provinceId);
            return response;
        }
    }
}
