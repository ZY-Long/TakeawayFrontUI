using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商家表
    /// </summary>
   public class BusinessInfo
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public int Id { get; set; }
        //商家图片
        public string Img { get; set; }
        //商家名称
        public string Name { get; set; }
        //联系电话
        public string PhoneNumber { get; set; }
        //负责人
        public string ContactPerson { get; set; }
        //商家地址
        public string Merchataddress { get; set; }
        public int States { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreaterId { get; set; }
        public int UpdaterId { get; set; }
    }
}
