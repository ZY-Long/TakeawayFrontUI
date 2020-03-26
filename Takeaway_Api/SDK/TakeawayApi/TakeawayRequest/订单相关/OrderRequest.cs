using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    /// <summary>
    /// 订单相关请求
    /// </summary>
    public class OrderRequest:BaseRequest
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 商家Id
        /// </summary>
        public int BusinessId { get; set; }

        public override string GetApiName()
        {
            return "/api/Order/GetOrderShow";
        }
    }
}
