using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class UpdateResponse:BaseResponse
    {
        //修改密码
        public List<UserInfo> userInfos { get; set; }
        public int User { get; set; }
    }
}
