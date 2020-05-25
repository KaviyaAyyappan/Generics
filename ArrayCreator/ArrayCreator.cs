using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayCreator
{
    class ArrayCreator
    {
        
        public static T[] Create <T> (int length, T item)
        {
            var len = new T[length];
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
                len[i] = item;
                Console.WriteLine(len[i] = item);
                
            }
            return len;
            
            
        }
        
        
        
        
    }
}
