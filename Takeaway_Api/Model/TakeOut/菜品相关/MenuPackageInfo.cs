using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 套餐菜品关联表
    /// </summary>
   public class MenuPackageInfo
    {
        //套餐菜品Id
        public int Id { get; set; }
        //套餐Id
        public int PackageId { get; set; }
        //类型Id
        public int TypeId { get; set; }
        //具体菜品Id
        public int DetailsId { get; set; }
        //数量
        public int Count { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
