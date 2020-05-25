using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //String input to the array
            string[] strings = ArrayCreator.Create(5, "Peter");
            //Integer input to the array
            int[] integers = ArrayCreator.Create(10, 33);
            Console.ReadLine();

        }
    }
}
