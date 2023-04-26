using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{

    public class Base
    {
        public void print()
        {
            Console.WriteLine("base class method");
        }
    }

    public class Derived : Base
    {
        public void print()
        {
            base.print();
            Console.WriteLine("Derived class method");
        }
    }

    public class MainEx
    {
        public static void aain(String[] args)
        {
            Derived derived = new Derived();
            derived.print();
        }
    }
}
