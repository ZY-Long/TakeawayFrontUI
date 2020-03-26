using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 市
    /// </summary>
   public class CityInfo
    {
        //市Id
        public int Id { get; set; }
        //市名称
        public string Name { get; set; }
        //省Id
        public int ProvinceId { get; set; }
    }
}
