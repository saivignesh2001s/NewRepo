using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderServices
{
    public class Employee
    {
        public int EmployeeId
        {
            get;
            set;
        }
        public string Ename
        {
            get;set;
        }
        public int age
        {
            get;
            set;
        }
        public bool Isretired()
        {
            return age >= 60;
        }
    }
}
