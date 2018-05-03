using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool IsValidCustomer(string UserName, String Password)
        {
            bool found = false;
            foreach (Customer s in CustomerDL.Customers)
            {
                if (s.getusername() == UserName && s.getpassword() == Password)
                {
                    found = true;
                    return found;
                }
            }
            return found;
        }
        public void make_transaction(string pin, string amount)
        {
            Transaction_Via_Pin tr = new Transaction_Via_Pin();
            tr.setamount(amount);
            tr.setpin(pin);
            TransactionViaPinDL.Transaction.Add(tr);
        }
        public string recieve_money_via_pin(string pin)
        {
            foreach (Transaction_Via_Pin p in TransactionViaPinDL.Transaction)
            {
                if (pin == p.getPin())
                {
                    return p.getamount();
                }
            }
            return "not valid pin";
        }

        public List<Customer> ListOfCustomers()
        {
            List<Customer> cus = CustomerDL.Customers;
            return cus;
        }
        public void registerUser(string username, string password, string CNIC, string ContactNo,string account,string amount)
        {
            Customer customer = new Customer();
            customer.setusername(username);
            customer.setpassword(password);
            customer.setContactNo(ContactNo);
            customer.setCNIC(CNIC);
            Account a = new Account();
            a.SetAccount_no(account);
            a.SetAmount(int.Parse(amount));
            customer.setaccount(a);
            CustomerDL.Customers.Add(customer);
        }
        public bool IsValid(string username, string password)
        {
            Admin admin = new Admin();
            if (admin.getusername() == username && admin.getpassword() == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TransactionViaAccount(string debitor, string creditor,string amount)
        {
            foreach (Customer c in CustomerDL.Customers)
            {
                if (debitor == c.getAccount().GetAccount_no())
                {
                    c.getAccount().SetAmount(c.getAccount().GetAmount() - int.Parse(amount));
                }
                if (creditor == c.getAccount().GetAccount_no())
                {
                    c.getAccount().SetAmount(c.getAccount().GetAmount() + int.Parse(amount));
                }
            }

        }
        public List<Transaction_via_Account> transactionsviaAccount()
        {
            List<Transaction_via_Account> t = TransactionViaAccount_DL.Transaction;
            return t;
        }
        public List<Transaction_Via_Pin> transactionsviaPin()
        {
            List<Transaction_Via_Pin> t = TransactionViaPinDL.Transaction;
            return t;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
