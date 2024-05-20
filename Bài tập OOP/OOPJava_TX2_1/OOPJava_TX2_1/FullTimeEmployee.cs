using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, double paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override double calculateSalary()
        {
            return (PaymentPerHour * 8);
        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
