using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    /// <summary>
    /// 地区相关BLL
    /// </summary>
    public class AreaBLL
    {
        /// <summary>
        /// 获取地区集合
        /// </summary>
        public AreaResponse GetArealnfos(AreaRequest areaRequest)
        {
            return ApiRequestHelper.Post<AreaRequest, AreaResponse>(areaRequest);
        }
    }
}
