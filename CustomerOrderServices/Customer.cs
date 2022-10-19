using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderServices
{
    public enum Ctype
    {
        Gold,Silver,Premium

    }
    public class Customer
    {
        
        private string _custid;
        public string Custid
        {
            get { return _custid; }
            set { _custid = value; }
        }
        private string _cusName;
        public string CusName
        {
            get { return _cusName; }
            set { _cusName = value; }
        }
        public Ctype Ctype
        {
            get;
            set;
        }
        public List<Customer> GetCustomers
        {
            get;
            set;
        }
    }
}
