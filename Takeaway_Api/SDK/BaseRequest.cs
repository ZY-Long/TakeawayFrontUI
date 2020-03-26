using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    /// <summary>
    /// 请求的基类
    /// </summary>
   public class BaseRequest
    {
        /// <summary>
        /// 返回接口的名称
        /// </summary>
        /// <returns></returns>
        public virtual string GetApiName()
        {
            return "";
        }
    }
}
