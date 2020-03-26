using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    /// <summary>
    /// 城市相关BLL
    /// </summary>
    public class CityBLL
    {
        /// <summary>
        /// 获取城市集合
        /// </summary>
        public CityResponse GetCityInfos(CityRequest cityRequest)
        {
            return ApiRequestHelper.Post<CityRequest, CityResponse>(cityRequest);
        }
    }
}
