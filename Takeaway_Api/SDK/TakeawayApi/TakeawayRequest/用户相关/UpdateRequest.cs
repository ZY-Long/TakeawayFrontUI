using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class UpdateRequest:BaseRequest
    {
        //修改密码
        public override string GetApiName()
        {
            return "/api/UserInfo/EditUserPwd";
        }
        public UserInfo user { get; set; }
        public string  pwd { get; set; }
        public int id { get; set; }
    }
}
