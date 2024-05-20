using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPJava_TX2_1
{
    class PartTimeEmployee : Employee
    {
        private double workingHour;

        public PartTimeEmployee(string name, double paymentPerHour, double workingHour) : base(name, paymentPerHour)
        {
            this.workingHour = workingHour;
        }

        public override double calculateSalary()
        {
            return (workingHour * PaymentPerHour);
        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return base.ToString() + $", Working hours: {workingHour}";
        }
    }
}
