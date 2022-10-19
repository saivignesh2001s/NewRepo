using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace CustomerOrderServices
{
   public class CustomerOrder
    {
        public void Discount(Customer c,Order r)
        {
            if (c.Ctype==Ctype.Premium)
            {
                r.Amount = r.Amount - (r.Amount * 0.1);

            }
            else if(c.Ctype == Ctype.Gold)
            {
                r.Amount = r.Amount - (r.Amount * 0.2);
            }
            else
            {
                r.Amount = r.Amount;
            }

        }
        public List<Customer> GetCustomersList()
        {
            List<Customer> list = new List<Customer>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["App"].ConnectionString);
            conn.Open();
            SqlCommand cd = new SqlCommand("Select * from Customers", conn);
            SqlDataReader ds=cd.ExecuteReader();
            while (ds.Read())
            {
                Customer customer = new Customer();
                customer.Custid = ds["CustomerID"].ToString();
                customer.CusName = ds["ContactName"].ToString();
                customer.Ctype = Ctype.Silver;
                list.Add(customer);

            }
            conn.Close();
            return list;
        }
    }
}
