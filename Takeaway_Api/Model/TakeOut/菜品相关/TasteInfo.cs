using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 口味表
    /// </summary>
   public class TasteInfo
    {
        //口味Id
        public int Id { get; set; }
        //口味名称
        public string Name { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
