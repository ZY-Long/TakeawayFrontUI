using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using SDK;

namespace Api
{
    /// <summary>
    /// 省份相关控制器
    /// </summary>
    public class ProvinceController : ApiController
    {
        /// <summary>
        /// 获取省份集合
        /// </summary>
        /// <param name="cityRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ProvinceResponse GetProvinceInfos(ProvinceRequest provinceRequest)
        {
            ProvinceResponse response = new ProvinceResponse();
            response.ProvinceInfos = BaseBLL<ProvinceBLL>.Instance.GetProvinceInfos();
            return response;
        }
    }
}
