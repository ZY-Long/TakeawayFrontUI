using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 活动表
    /// </summary>
   public class Activity
    {
        //活动Id
        public int Id { get; set; }
        //活动名称
        public string Name { get; set; }
        //活动介绍
        public string Content { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
