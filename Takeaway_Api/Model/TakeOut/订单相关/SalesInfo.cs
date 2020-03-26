using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 销量表
    /// </summary>
   public class SalesInfo
    {
        //销售Id
        public int Id { get; set; }
        //类型Id
        public int TypeId { get; set; }
        //具体Id
        public int DetailsId { get; set; }
        //销量
        public int Sales { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }

    }
}
