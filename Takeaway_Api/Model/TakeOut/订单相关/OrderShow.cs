using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 显示订单信息
    /// </summary>
    public class OrderShow
    {
        /// <summary>
        /// 购物车Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 店铺电话
        /// </summary>
        public string BusinessNumber { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        public string Merchataddress { get; set; }

        /// <summary>
        /// 菜品总价
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// list信息
        /// </summary>
        public List<ListOrder> list { get; set; }
    }
}
