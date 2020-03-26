using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace SDK
{
   public class DeleteCartRequest : BaseRequest
    {
        public CartDetails DeleteCart  { get; set; }
        public override string GetApiName()
        {
            return "/api/Crat/DeleteCare";
        }
    }
}
