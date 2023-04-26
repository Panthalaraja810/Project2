using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class overrideEx
    {
    }
    public class A1
    {
        public virtual void show()
        {
            Console.WriteLine("Hello : Base class");
        }
    }
    public class B1 : A1
    {
        public override void show()
        {
            Console.WriteLine("Hello : Derived class");
        }
    }


}
