using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Transaction_via_Account
    {
        [DataMember]
        string Debitor_Account;
        [DataMember]
        string Creditor_Account;
        [DataMember]
        string Amount;
        public string getDebitor_Account()
        {
            return Debitor_Account;
        }
        public void setDebitor_Account(string s)
        {
            Debitor_Account = s;
        }
        public string getCreditor_Account()
        {
            return Creditor_Account;
        }
        public void setCreditor_Account(string s)
        {
            Creditor_Account = s;
        }
        public string getAmount()
        {
            return Amount;
        }
        public void setAmount(string s)
        {
            Amount = s;
        }
    }
}