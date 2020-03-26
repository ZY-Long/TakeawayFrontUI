using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDK
{
    public class AddRequest : BaseRequest
    {
        //显示地址信息
        public override string GetApiName()
        {
            return "/api/UserInfo/ShowressInfo";
        }

    }
}
