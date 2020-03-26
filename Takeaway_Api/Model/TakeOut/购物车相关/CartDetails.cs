using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 购物车详情表
    /// </summary>
   public class CartDetails
    {
        //购物车详情Id
        public int Id { get; set; }
        //购物车Id
        public int CratId { get; set; }
        //类型Id
        public int TypeId { get; set; }
        //菜品酒水具体Id
        public int DetailsId { get; set; }
        //购物车数量
        public int Count { get; set; }
        //口味Id
        public int TasteId { get; set; }
        //总价钱
        public decimal ToPrice { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }

    }
}
