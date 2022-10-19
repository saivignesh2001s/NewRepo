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
    [TestFixture]
    public class EmployeeServiceTest
    {
        [TestCase(16,ExpectedResult =false)]
        [TestCase(26, ExpectedResult = false)]
        [TestCase(66, ExpectedResult = true)]
        [TestCase(76, ExpectedResult = true)]
        public bool TesTretired(int age)
        {
            Employee s = new Employee();
            s.EmployeeId = 123;
            s.Ename = "Sai";
            s.age = age;
            bool ans = s.Isretired();
            return ans;
                   }

   
    }
}
