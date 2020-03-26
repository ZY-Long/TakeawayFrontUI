using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    //添加新地址
   public  class AdLoctionRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/UserInfo/AddressInfo";
        }
        public AddressInfo user { get; set; }
        public AddressInfo info { get; set; }
    }
}
