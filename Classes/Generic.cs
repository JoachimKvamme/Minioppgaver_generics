using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.Classes
{
    public class Generic
    {

        // 
        static void SwapOrConcatenate<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

            
        }
    }
}