using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 显示订单相关的集合信息
    /// </summary>
    public class ListOrder
    {
        /// <summary>
        /// 菜品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 菜品图片
        /// </summary>
        public string Img { get; set; }


        /// <summary>
        /// 菜品价格
        /// </summary>
        public double ToPrice { get; set; }

    }
}
