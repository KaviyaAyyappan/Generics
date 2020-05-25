using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            var scaleValue = new Scale<int>(16, 15);
            Console.WriteLine(scaleValue.GetHeavier());
            Console.ReadLine();
        }
    }
}
