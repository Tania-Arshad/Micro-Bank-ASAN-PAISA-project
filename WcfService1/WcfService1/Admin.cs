using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Admin
    {
        string username = "Manager";
        string password = "grand*11";
        public string getusername()
        {
            return username;
        }
        public string getpassword()
        {
            return password;
        }
    }
}