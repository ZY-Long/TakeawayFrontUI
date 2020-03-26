using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

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
        /// <param name="UserId"></param>
        /// <param name="BusinessId"></param>
        /// <returns></returns>
        public OrderShow GetOrderShow(int UserId, int BusinessId)
        {
            return BaseDAL<OrderDAL>.Instance.GetOrderShow(UserId,BusinessId);

        }

        /// <summary>
        /// 生成订单信息
        /// </summary>
        /// <returns></returns>
        public int GenerateOrder(OrderParameter parameter)
        {
            return BaseDAL<OrderDAL>.Instance.GenerateOrder(parameter);
        }

    }
}
