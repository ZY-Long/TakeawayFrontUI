using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BLL
{
    public class UserBll
    {

        /// <summary>
        /// 注册用户
        /// </summary>
        public UserInfoResponse AddUser(UserRequest userRequest)
        {
            return ApiRequestHelper.Post<UserRequest, UserInfoResponse>(userRequest);
        }
        //登陆
        public UserInfoResponse InfoResponse(UserRequest request)
        {
            return ApiRequestHelper.Post<UserRequest,UserInfoResponse>(request);
        }
        //找回密码
        public ZhaopwdResponse FindPwd(ZhaopwdRequest request)
        {
            return ApiRequestHelper.Post<ZhaopwdRequest, ZhaopwdResponse>(request);
        }
        //修改密码
        public UpdateResponse EditUserPwd(UpdateRequest request)
        {
            return ApiRequestHelper.Post<UpdateRequest,UpdateResponse>(request);
        }
        //修改用户地址
        public LocationResponse EditUserInfo(LocationRequest request)
        {
            return ApiRequestHelper.Post<LocationRequest, LocationResponse>(request);
        }
        //显示地址信息
        public ShowResponse ShowressInfo(ShowRequest request)
        {
            return ApiRequestHelper.Post<ShowRequest, ShowResponse>(request);
        }
        //添加新地址
        public AdLoctionResponse AddressInfo(AdLoctionRequest request)
        {
            return ApiRequestHelper.Post<AdLoctionRequest, AdLoctionResponse>(request);
        }
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
