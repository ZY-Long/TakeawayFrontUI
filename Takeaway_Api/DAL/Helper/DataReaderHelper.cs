using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
   public static class DataReaderHelper
    {
        public static List<T> DataReaderToList<T>(this SqlDataReader reader)where T:new()
        {
            List<T> list = new List<T>();
            while (reader.Read())
            {
                T t = new T();
                var pops = t.GetType().GetProperties();
                foreach (var pop in pops)
                {
                    pop.SetValue(t,reader[pop.Name]);
                }
                list.Add(t);
            }
            return list;
        }
    }
}
