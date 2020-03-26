using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    /// 找回密码
    public class ZhaopwdResponse:BaseResponse
    {
        public List<UserInfo>  userInfos { get; set; }
    }
}
