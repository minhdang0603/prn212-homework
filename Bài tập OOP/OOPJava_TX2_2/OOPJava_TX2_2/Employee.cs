using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    internal class Employee : Person 
    {

        public int Salary {  get; set; }

        public override void display()
        {
            base.display();
            Console.WriteLine(", Salary: {0}", Salary);
        }
    }
}
