using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
   public  class UserDbContext:DbContext
    {
        public UserDbContext() : base("EFConnect")
        { 
         
        }
        public DbSet<UserInfo> GetInfos { get; set;}
    }
}
