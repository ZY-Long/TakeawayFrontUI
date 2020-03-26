using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
   public  class AdLoctionResponse:BaseResponse
    {
        //添加新地址
        public List<AddressInfo>  addressInfos { get; set; }
        public int User { get; set; }
    }
}
