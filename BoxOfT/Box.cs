using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    class Box<T>
    {
        List<T> value = new List<T>();
        public void Add(T element) 
        {
            value.Add(element);
        }
        public T Remove()
        {
            T rem = value[value.Count - 1];
            value.RemoveAt(value.Count - 1);
            return rem;
        }
        
       public int Count { get; }
        
    }
}
