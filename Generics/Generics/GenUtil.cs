using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenUtil
    {

        public static void Exchange<MyType>(ref MyType x, ref MyType y)
        {
            MyType temp = x;
            x = y;
            y = temp;
        }
    }
    

}
  