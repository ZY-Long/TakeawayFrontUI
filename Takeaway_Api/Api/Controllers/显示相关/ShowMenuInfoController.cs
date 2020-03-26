using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;

namespace Api
{
    public class ShowMenuInfoController:ApiController
    {
        public SqlDataReader Show(int currPage, string Name, int TypeId)
        {
            return BaseBLL<FoodShowBLL>.Instance.Show(currPage, Name, TypeId);
        }

    }
}
