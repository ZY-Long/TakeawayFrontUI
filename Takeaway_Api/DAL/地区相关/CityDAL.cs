using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// 城市相关DAL
    /// </summary>
    public class CityDAL
    {
        /// <summary>
        /// 获取城市集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<CityInfo> GetCityInfos(int provinceId)
        {
            List<CityInfo> infos = OrmDBHelper.GetToList<CityInfo>("SELECT * FROM dbo.CityInfo WHERE ProvinceId ="+provinceId);
            return infos;
        }
    }
}
