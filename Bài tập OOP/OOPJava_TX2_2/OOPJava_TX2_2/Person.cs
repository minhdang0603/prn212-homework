using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJava_TX2_2
{
    internal abstract class Person
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public virtual void display()
        {
            Console.Write("Name: {0}, Address: {1}", Name, Address);
        }
    }
}
