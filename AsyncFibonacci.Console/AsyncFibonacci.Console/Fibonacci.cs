using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Console
{
    public class Fibonacci
    {
        public static long GetFibonacciNumber(long fibonacciNumber)
        {
            if (fibonacciNumber < 0)
            {
                return 0;
            }
            else if (fibonacciNumber == 1)
            {
                return 1;
            }
            else
            {
                var result1 = GetFibonacciNumber(fibonacciNumber - 1);
                var result2 = GetFibonacciNumber(fibonacciNumber - 2);

                return result1 + result2;
            }
        }
    }
}
