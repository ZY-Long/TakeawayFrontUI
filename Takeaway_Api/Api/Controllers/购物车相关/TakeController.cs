using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
using SDK;
namespace Api.Controllers.购物车相关
{
    public class TakeController : ApiController
    {
        public TakeResponse GetTakeInfos()
        {
            TakeResponse response = new TakeResponse();
            response.TaseInfos = BaseBLL<TakeBLL>.Instance.ShowTasteInfo();
            return response;
        }
    }
}
