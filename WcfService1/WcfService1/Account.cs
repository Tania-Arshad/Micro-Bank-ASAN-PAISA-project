using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Account
    {
        private string Account_no;
        private int Amount;
        public string GetAccount_no()
        {
            return Account_no;
        }
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAccount_no(string number)
        {
            Account_no = number;
        }
        public void SetAmount(int rupees)
        {
            Amount = rupees;
        }
    }
}