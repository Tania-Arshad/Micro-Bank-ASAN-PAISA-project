using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public List<Loan> loans = new List<Loan>();
        [DataMember]
        string username;
        [DataMember]
        string password;
        [DataMember]
        string CNIC;
        [DataMember]
        string ContactNo;
        [DataMember]
        Account account;
        public Account getAccount()
        {
            return account;
        }
        public void setaccount(Account s)
        {
            account = s;
        }
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