using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Transaction_Via_Pin
    {
        string pin;
        string amount;
        public string getPin()
        {
            return pin;
        }
        public void setpin(string s)
        {
            pin = s;
        }
        public string getamount()
        {
            return amount;
        }
        public void setamount(string s)
        {
            amount = s;
        }
    }
}