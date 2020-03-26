using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    /// <summary>
    /// 省份相关BLL
    /// </summary>
    public class ProvinceBLL
    {
        /// <summary>
        /// 获取省份集合,用作下拉
        /// </summary>
        /// <returns></returns>
        public List<ProvinceInfo> GetProvinceInfos()
        {
            return BaseDAL<ProvinceDAL>.Instance.GetProvinceInfos();
        }
    }
}
