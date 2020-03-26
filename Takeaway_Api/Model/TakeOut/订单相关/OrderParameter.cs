using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 添加订单信息
    /// </summary>
    public class OrderParameter
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 店铺联系电话
        /// </summary>
        public string BusinessNumber { get; set; }

        /// <summary>
        /// 店铺位置
        /// </summary>
        public string Merchataddress { get; set; }

        /// <summary>
        /// 地址Id
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// 餐具数量
        /// </summary>
        public int TablewareCount { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Content { get; set; }

    }
}
