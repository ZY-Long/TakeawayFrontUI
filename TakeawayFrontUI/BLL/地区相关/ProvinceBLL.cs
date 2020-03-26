using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    /// <summary>
    /// 省份相关BLL
    /// </summary>
    public class ProvinceBLL
    {
        /// <summary>
        /// 获取省份集合
        /// </summary>
        public ProvinceResponse GetProvinceInfos(ProvinceRequest provinceRequest)
        {
            return ApiRequestHelper.Post<ProvinceRequest, ProvinceResponse>(provinceRequest);
        }
    }
}
