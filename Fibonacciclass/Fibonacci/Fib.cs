using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci
{
    class Fib
    {
        
        public  BigInteger this[BigInteger i]
        {
            get
            {
                if (i < 0) throw new ArgumentOutOfRangeException();
                if (i == 0) return 0;
                if (i == 1) return 1;
               BigInteger a = 0;
               BigInteger b = 1;
               BigInteger c = 0;
                for (int j = 2;j<=i;j++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }

           
        }
       
    }
}
