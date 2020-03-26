using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// <summary>
    /// 城市相关返回
    /// </summary>
    public class CityResponse:BaseResponse
    {
        public List<CityInfo> CityInfos { get; set; }
    }
}
