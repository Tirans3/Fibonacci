using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

namespace Fibonacci
{
   class Fib:IEnumerable
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

        BigInteger temp;

      public  Fib(BigInteger input)
        {
            temp = input;
        }

        public IEnumerator GetEnumerator()
        {
            BigInteger i = 0;

            do
            {
                yield return this[i];
                i++;
            } while (i != temp);
           
        }



        public  string InformaboutFibNumber(BigInteger i)
       {
            string s= $"Fib({i}) = {this[i]};\n ";
            if(this[i].IsZero) s += $"Fib({i}) is zero\n ";
            if(this[i].IsOne)  s += $"Fib({i}) is One\n ";
            if (this[i].IsEven) s += $"Fib({i}) is Even\n ";
            if (this[i].IsPowerOfTwo) s += $"Fib({i}) is Power Of Two\n ";
            return s;
        }
    }
}
