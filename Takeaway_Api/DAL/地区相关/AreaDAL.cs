using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// 地区相关DAL
    /// </summary>
    public class AreaDAL
    {
        /// <summary>
        /// 获取城市集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<Arealnfo> GetArealnfos(int cityId)
        {
            List<Arealnfo> infos = OrmDBHelper.GetToList<Arealnfo>("SELECT * FROM dbo.Arealnfo WHERE CityId= " + cityId);
            return infos;
        }
    }
}
