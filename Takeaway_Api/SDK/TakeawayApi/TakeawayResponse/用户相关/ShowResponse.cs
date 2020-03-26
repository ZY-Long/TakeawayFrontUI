using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class ShowResponse:BaseResponse
    {
        //显示地址
        public List<AddressInfo> userInfos { get; set; }
        public int User { get; set; }
    }
}
