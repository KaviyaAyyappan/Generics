using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class Scale<T>
            where T : IComparable<T>


    {
        private T left;
        private T right;
        public Scale(T left,T right)
        {
            this.left = left;
            this.right = right;
        }
        public T GetHeavier()
            {
            var compare = this.left.CompareTo(this.right);
            if (compare > 0)
            {
                Console.WriteLine("Left is heavier than Right");
                return left;
            }
            else if (compare < 0)
            {
                Console.WriteLine("Right is heavier than left");
                return right;
            }
                      
            Console.WriteLine("NULL");
            return default(T);

        }
    }
}
