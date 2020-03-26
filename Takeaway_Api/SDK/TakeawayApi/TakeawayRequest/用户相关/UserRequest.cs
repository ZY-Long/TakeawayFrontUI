using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    //注册
    public class UserRequest : BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/UserInfo/AddUser";
        }
        public UserInfo user { get; set; }
    }
}
