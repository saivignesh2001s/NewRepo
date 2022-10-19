using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;
using CustomerOrderServices;

namespace CustomerOrderService.Test
{
    [TestFixture(Ctype.Premium,100)]
    [TestFixture(Ctype.Silver)]
    public class CustomerOrdersTest
    {
        Ctype ctype;
        Ctype ctype1;
            Order o=new Order();
        public CustomerOrdersTest(Ctype ctype)
        {
            this.ctype = ctype;
        }
        public CustomerOrdersTest(Ctype ctype1,double amount)
        {
            ctype = ctype1;
            o.Amount = amount;
        }
        [TestCase]
        public void TestMethod1()
        {
            Assert.IsTrue(ctype==Ctype.Premium && o.Amount > 0);
        }
        [TestCase]
        public void TestMethod()
        {
            Assert.That(ctype == Ctype.Silver);
        }
       [TestCase]
        public void When_Premium()
        {
            Customer c = new Customer();
            c.Custid = "1";
            c.CusName = "Sai";
            c.Ctype = Ctype.Premium;
            Order order = new Order();
            order.OrderId = 1234;
            order.ProductId = 2;
            order.Quantity = 4;
            order.Amount = 4000;
            CustomerOrder c1 = new CustomerOrder();
            c1.Discount(c, order);
            Assert.AreEqual(3600,order.Amount);
           
        }
        [TestCase]
        public void When_Gold()
        {
            Customer c = new Customer();
            c.Custid = "2";
            c.CusName = "Saivig";
            c.Ctype = Ctype.Gold;
            Order order = new Order();
            order.OrderId = 1235;
            order.ProductId = 2;
            order.Quantity = 4;
            order.Amount = 4000;
            CustomerOrder c1 = new CustomerOrder();
            c1.Discount(c,order);
            Assert.AreEqual(3200, order.Amount);

        }
        [TestCase]
        public void WhenInsert()
        {
            Customer c= new Customer();
            CustomerOrder c1 = new CustomerOrder();
            c.GetCustomers = c1.GetCustomersList();
            List<Customer> c2 = new List<Customer>();
            Customer c3 = new Customer();
            c3.Custid = "dd";
            c3.CusName = "Dude";
            c3.Ctype = Ctype.Premium;
            c2.Add(c3);
            Assert.AreEqual(c.GetCustomers, c2);

        }
    }
}
