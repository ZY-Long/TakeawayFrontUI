using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单详情表
    /// </summary>
   public class OrderDetails
    {
        //订单详情Id
        public int Id { get; set; }
        //订单Id
        public int OrderId { get; set; }
        //菜品酒水套餐类型Id
        public int TypeId { get; set; }
        //菜品酒水套餐具体Id
        public int DetailsId { get; set; }
        //数量
        public int Count { get; set; }
        //口味Id
        public int TasteId { get; set; }
        //备注
        public string Content { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }

    }
}
