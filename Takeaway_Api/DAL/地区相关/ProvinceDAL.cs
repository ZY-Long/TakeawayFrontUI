using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// 省份相关DAL
    /// </summary>
    public class ProvinceDAL
    {
        /// <summary>
        /// 获取省份集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<ProvinceInfo> GetProvinceInfos()
        {
            List<ProvinceInfo> infos = OrmDBHelper.GetToList<ProvinceInfo>("SELECT * FROM dbo.ProvinceInfo");
            return infos;
        }
    }
}
