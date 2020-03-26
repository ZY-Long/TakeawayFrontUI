using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    public class DeLoginRequest : BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/UserInfo/DeLogin";
        }
        public int user { get; set; }
    }
}
