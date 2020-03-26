using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// <summary>
    /// 省份相关返回
    /// </summary>
    public class ProvinceResponse:BaseResponse
    {
        public List<ProvinceInfo>  ProvinceInfos { get; set; }
    }
}
