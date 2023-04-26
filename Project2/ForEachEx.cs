using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class ForEachEx
    {
    }

    class   FOREACHEx
    {
        public static void Main(String[] args)
        {
            int[] array ={ 5, 78, 9, 65, 4, 1, 2 };

            foreach(int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
