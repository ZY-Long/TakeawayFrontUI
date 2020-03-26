using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    public class ShowBll
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="show"></param>
        /// <returns></returns>
        public ShowResponse Show(ShowRequest show)
        {
            return ApiRequestHelper.Post<ShowRequest, ShowResponse>(show);
        }
    }
}
