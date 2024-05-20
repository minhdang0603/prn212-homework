using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_1
{
    internal abstract class Employee : IEmployee
    {
        
        public Employee(string name, double paymentPerHour)
        {
            this.Name = name;
            this.PaymentPerHour = paymentPerHour;
        }

        public string Name { get; set; }

        public double PaymentPerHour { get; set; }

        public abstract double calculateSalary();

        public abstract string getName();

        public virtual string ToString()
        {
            return $"Name: {Name}, Payment per Hour: {PaymentPerHour}";
        }
    }
}
