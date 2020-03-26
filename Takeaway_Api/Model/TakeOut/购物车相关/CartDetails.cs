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


        public int Count { get; set; }

        public string Img { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
