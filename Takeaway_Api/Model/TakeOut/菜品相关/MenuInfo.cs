using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 菜品表
    /// </summary>
    public class MenuInfo
    {
        //菜单Id
        public int Id { get; set; }
        //菜品名称
        public string Name { get; set; }
        //菜单图片
        public string Img { get; set; }
        //菜单价钱
        public decimal Price { get; set; }
        //类型Id为2是酒水
        public int TypeId { get; set; }
        //菜单备注
        public string Remark { get; set; }
        //商家Id
        public int BusinessInfo { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
