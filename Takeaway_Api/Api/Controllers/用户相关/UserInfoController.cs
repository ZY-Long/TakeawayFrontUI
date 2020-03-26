using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
using SDK;

namespace Api.Controllers
{
    public class UserInfoController : ApiController
    {
        //注册用户
        public UserInfoResponse AddUser(UserRequest request)
        {
            return BaseBLL<UserInfobll>.Instance.AddUser(request);
        }
        //登陆
        public UserInfoResponse InfoResponse(UserRequest request)
        {
            return BaseBLL<UserInfobll>.Instance.InfoResponse(request);
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="PassWord"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        public ZhaopwdResponse FindPwd(ZhaopwdRequest request)
        {
            ZhaopwdResponse response = new ZhaopwdResponse();
            string Content = "";
            string res =BaseBLL<UserInfobll>.Instance.FindPwd(request.PhoneNumber,request.PassWord, request.Email);

            if (!string.IsNullOrEmpty(res))
            {
                Content = "您好,您的密码为" + res;
                ForgetPwd(request.Email, Content);
            }
            else
            {
                Content = "您的账户出现问题,请重试";
                ForgetPwd(request.Email, Content);
            }

            return response;

        }
        //邮箱
        public void ForgetPwd(string Email, string Content)
        {

        }
        ///修改密码
        public UpdateResponse EditUserPwd(UpdateRequest request)
        {
            UpdateResponse response = new UpdateResponse();
            response.User= BaseBLL<UserInfobll>.Instance.EditUserPwd(request.pwd, request.id);
            return response;
        }
        //修改用户地址
        public LocationResponse EditUserInfo(LocationRequest request)
        {
            LocationResponse response = new LocationResponse();
            response.User = BaseBLL<UserInfobll>.Instance.EditUserInfo(request.content, request.id);
            return response;
        }
        //显示地址信息
        public ShowResponse ShowressInfo(ShowRequest request)
        {
            ShowResponse response = new ShowResponse();
            response.User=Convert.ToInt32( BaseBLL<UserInfobll>.Instance.ShowressInfo());
            return response;
        }
        //添加新地址
        public AdLoctionResponse AddressInfo(AdLoctionRequest request,AddressInfo info)
        {
            AdLoctionResponse response = new AdLoctionResponse();
            response.User=Convert.ToInt32(BaseBLL<UserInfobll>.Instance.AddressInfo(info));
            return response;
             
        }
    }
}
