using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    internal class Customer : Person
    {
        public int Balance { get; set; }


        public override void display()
        {
            base.display();
            Console.WriteLine(", Salary: {0}", Balance);
        }
    }
}
