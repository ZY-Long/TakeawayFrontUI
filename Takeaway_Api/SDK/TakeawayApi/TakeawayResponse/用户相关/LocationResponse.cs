using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class LocationResponse:BaseResponse
    {
        //修改用户地址
        public List<UserInfo> userInfos { get; set; }
        public int User { get; set; }
    }
}
