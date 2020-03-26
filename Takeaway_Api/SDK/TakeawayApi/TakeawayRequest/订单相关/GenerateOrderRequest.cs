using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// <summary>
    /// 生成订单信息请求
    /// </summary>
    public class GenerateOrderRequest : BaseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public OrderParameter parameter { get; set; }

        public override string GetApiName()
        {
            return "/api/Order/GenerateOrder"; 
        }
    }
}
