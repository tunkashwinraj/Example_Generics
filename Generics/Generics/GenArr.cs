using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenArr
    {
        public static T FindMax<T>(T[] Arr)
        where T : IComparable<T>
        {
            T max = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i].CompareTo(max) == 1)
                    max = Arr[i];
                
            }
            return max;
        }
        public static T[] InitArray<T>(int size)
        where T : new()
        {
            T[] Arr = new T[size];
            for (int i = 0; i < size; i++)
                Arr[i] = new T();
            return Arr;
        }
    }
}
