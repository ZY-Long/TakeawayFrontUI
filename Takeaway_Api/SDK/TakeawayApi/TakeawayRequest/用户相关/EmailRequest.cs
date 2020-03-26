using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK

{
    //邮箱
   public  class EmailRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/UserInfo/ForgetPwd";
        }
    }
}
