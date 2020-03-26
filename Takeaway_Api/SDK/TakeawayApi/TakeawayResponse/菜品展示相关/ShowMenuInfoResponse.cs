using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    public class ShowMenuInfoResponse : BaseResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int currPage { get; set; }
        /// <summary>
        /// 菜品名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜品类型
        /// </summary>
        public int TypeId { get; set; }
    }
}
