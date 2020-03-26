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
    /// 城市相关BLL
    /// </summary>
    public class CityBLL
    {
        /// <summary>
        /// 获取城市集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<CityInfo> GetCityInfos(int provinceId)
        {
            return BaseDAL<CityDAL>.Instance.GetCityInfos(provinceId);
        }
    }
}
