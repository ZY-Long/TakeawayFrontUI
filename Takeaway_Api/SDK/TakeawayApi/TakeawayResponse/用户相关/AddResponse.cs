using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    //显示地址信息
   public  class AddResponse:BaseResponse
    {
        public List<AddressInfo>  addressInfos { get; set; }
    }
}
