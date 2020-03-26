using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
   public class TakeRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Crat/GetTakeInfos";
        }
    }
}
