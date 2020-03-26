using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    /// <summary>
    /// 地区相关BLL
    /// </summary>
    public class AreaBLL
    {
        /// <summary>
        /// 获取城市集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<Arealnfo> GetArealnfos(int cityId)
        {
            return BaseDAL<AreaDAL>.Instance.GetArealnfos(cityId);
        }
    }
}
