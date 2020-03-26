using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDK;
using Model;
using BLL;
namespace Api
{
    public class CratDeController : ApiController
    {
        [HttpPost]
        public GetCartResponse GetCartInfos(GetCartRequest request)
        {
            GetCartResponse response = new GetCartResponse();
            response.GetCart = BaseBLL<TakeBLL>.Instance.GetCartInfos();
            return response;
        }
    }
}
