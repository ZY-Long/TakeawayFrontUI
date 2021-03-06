﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
using SDK;
namespace Api
{
    public class TakeController : ApiController
    {
        [HttpPost]
        public TakeResponse GetTakeInfos()
        {
            TakeResponse response = new TakeResponse();
            response.TaseInfos = BaseBLL<TakeBLL>.Instance.ShowTasteInfo();
            return response;
        }
    }
}
