using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
namespace DAL
{
    public class UserInfo
    {
        private UserInfo() { }
        public static UserInfo _instance = new UserInfo();
        public static UserInfo Instance
        {
            get
            {
                return _instance;
            }
        }
  
    }
}
