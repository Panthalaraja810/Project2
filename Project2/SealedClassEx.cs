using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public sealed class PersonEx     //declaring a class sealed
    {
        public String name;
    }

    public class StudentEx // : Person  //cannot inherit a sealed class, will throw error
    {
        public int id;
    }

    class ProgramEx
    {
        public static void aain(String[] args)
        {
            Console.WriteLine(" ");
        }
    }
}
