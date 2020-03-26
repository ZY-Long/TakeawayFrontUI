using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    /// <summary>
    ///城市相关请求
    /// </summary>
    public class CityRequest:BaseRequest
    {
        /// <summary>
        /// 省份Id
        /// </summary>
        public int provinceId { get; set; }

        public override string GetApiName()
        {
            return "/api/City/GetCityInfos";
        }
    }
}
