using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    /// <summary>
    /// 省份相关请求
    /// </summary>
    public class ProvinceRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Province/GetProvinceInfos";
        }
    }
}