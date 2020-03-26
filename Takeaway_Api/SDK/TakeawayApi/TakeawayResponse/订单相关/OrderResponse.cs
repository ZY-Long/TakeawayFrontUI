using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// <summary>
    /// 订单相关返回
    /// </summary>
    public class OrderResponse:BaseResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        public OrderShow Order { get; set; }
    }
}
