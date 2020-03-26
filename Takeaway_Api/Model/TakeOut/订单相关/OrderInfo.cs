using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
   public class OrderInfo
    {
        //订单Id
        public int Id { get; set; }
        //用户Id
        public int UserId { get; set; }
        //创建时间
        
        //地址Id
        public int AddressId { get; set; }
        //数据状态
        public int DataState { get; set; }
        //运费
        public decimal Freight { get; set; }
        //包装费
        public int PackagingFee { get; set; }
        //餐具数量
        public int TablewareCount { get; set; }
        //活动Id
        public int ActivityId { get; set; }
        //总价
        public decimal TotalPrice { get; set; }
        //收货人
        public string Consignee { get; set; }
        //商家Id
        public int BusinessInfo { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
