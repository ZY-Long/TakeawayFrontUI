using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    /// <summary>
    /// 地区相关请求
    /// </summary>
    public class AreaRequest : BaseRequest
    {
        /// <summary>
        /// 省份Id
        /// </summary>
        public int cityId { get; set; }

        public override string GetApiName()
        {
            return "/api/Area/GetArealnfos";
        }
    }
}
