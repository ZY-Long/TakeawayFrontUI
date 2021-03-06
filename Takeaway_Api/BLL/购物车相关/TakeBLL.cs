﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public class TakeBLL
    {
        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCart(int id)
        {
            return BaseDAL<TakeDAL>.Instance.DeleteCart(id);
        }
        /// <summary>
        /// 显示口味下拉框
        /// </summary>
        /// <returns></returns>

        public List<TasteInfo> ShowTasteInfo()
        {
            return BaseDAL<TakeDAL>.Instance.ShowTasteInfo();
        }
        /// <summary>
        /// 显示购物车
        /// </summary>
        /// <returns></returns>
        public List<CartDetails> GetCartInfos()
        {
            return BaseDAL<TakeDAL>.Instance.GetCartInfos();
        }
        //public int AddCart(CartInfo cart)
        //{
        //    return BaseDAL<TakeDAL>.Instance.AddCart(cart);
        //}
        /*添加购物车*/
       
    }
}
