using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Customer
    {
        string username;
        string password;
        string CNIC;
        string ContactNo;
        public string getusername()
        {
            return username;
        }
        public void setusername(string s)
        {
            username = s;
        }
        public string getpassword()
        {
            return password;
        }
        public void setpassword(string s)
        {
            password = s;
        }
        public string getCNIC()
        {
            return CNIC;
        }
        public void setCNIC(string s)
        {
            CNIC = s;
        }
        public string getContactNo()
        {
            return ContactNo;
        }
        public void setContactNo(string s)
        {
            ContactNo = s;
        }
    }
}