using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
   public  class DeLoginResponse:BaseResponse
    {
        public List<UserInfo> userInfos { get; set; }
    }
}
