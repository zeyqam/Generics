using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Intlist
    {
        private int[] intArray;
        public Intlist()
        {
            intArray = Array.Empty<int>();
        }

        public void Add(int num)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;
        }
        public int[] GetAll()
        {
            return intArray;
        }
    }
}
