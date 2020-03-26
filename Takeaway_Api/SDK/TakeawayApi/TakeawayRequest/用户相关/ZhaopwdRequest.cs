using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class ZhaopwdRequest:BaseRequest
    {
        //找回密码
        public override string GetApiName()
        {
            return "/api/UserInfo/FindPwd";
        }
        public string  PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
    }
}
