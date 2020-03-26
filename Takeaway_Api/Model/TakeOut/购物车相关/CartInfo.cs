using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 购物车
    /// </summary>
   public class CartInfo
    {
        //购物车Id
        public int Id { get; set; }
        //用户Id
        public int UserId { get; set; }
        //商家Id
        public int BusinessInfo { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
