using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// <summary>
    /// 地区相关返回
    /// </summary>
    public class AreaResponse:BaseResponse
    {
        public List<Arealnfo> Arealnfos { get; set; }
    }
}
