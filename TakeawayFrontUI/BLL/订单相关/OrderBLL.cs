using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    /// <summary>
    /// 订单相关BLL
    /// </summary>
    public class OrderBLL
    {
        /// <summary>
        /// 获取订单信息,用作显示
        /// </summary>
        public OrderResponse GetOrderShow(OrderRequest request)
        {
            return ApiRequestHelper.Post<OrderRequest, OrderResponse>(request);
        }

        /// <summary>
        /// 生成订单信息
        /// </summary>
        public GenerateOrderResponse GenerateOrder(GenerateOrderRequest request)
        {
            return ApiRequestHelper.Post<GenerateOrderRequest, GenerateOrderResponse>(request);
        }
    }
}
