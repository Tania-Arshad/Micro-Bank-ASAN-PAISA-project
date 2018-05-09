using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService1
{
    [DataContract]
    public class Loan
    {
        private string Date;
        private string Amount;
        public string GetDate()
        {
            return Date;
        }
        public string GetAmount()
        {
            return Amount;
        }
        public void SetDate(string number)
        {
            Date = number;
        }
        public void SetAmount(string rupees)
        {
            Amount = rupees;
        }
    }
}