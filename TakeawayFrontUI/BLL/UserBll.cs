using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;
using Newtonsoft.Json;

namespace BLL
{
    public class UserBll
    {

        ///// <summary>
        ///// 添加用户
        ///// </summary>
        //public UserAddResponse AddUser(UserAddRequest userAddRequest)
        //{
        //    return ApiRequestHelper.Post<UserAddRequest, UserAddResponse>(userAddRequest);
        //}

        ///// <summary>
        ///// 获取用户
        ///// </summary>
        ///// <param name="request"></param>
        //public void GetUserInfo(UserGetRequest request)
        //{
        //    UserGetResponse response = new UserGetResponse();
        //    ApiRequestHelper.Post<UserGetRequest, UserGetResponse>(request);
        //}


        /// <summary>
        /// 获取省份信息,用作绑定下拉框
        /// </summary>
        /// <param name="province"></param>
        /// <returns></returns>
        public ProvinceResponse GetProvince(ProvinceRequest province)
        {
            return ApiRequestHelper.Post<ProvinceRequest, ProvinceResponse>(province);
        }


    }
}
