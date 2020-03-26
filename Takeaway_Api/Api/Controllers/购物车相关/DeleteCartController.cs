using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using SDK;
using Model;
namespace Api
{
    public class DeleteCartController : ApiController
    {
        public DeleteCartResponse DeleteCare(int id)
        {
            DeleteCartResponse response = new DeleteCartResponse();
            response.delete = BaseBLL<TakeBLL>.Instance.DeleteCart(id);
            return response;
        }
    }
}
