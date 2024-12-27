using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Console
{
    public class FibonacciAsync
    {
        public static Task<long> GetFibonacciNumberAsync(long fibonacciNumber)
        {
            if (fibonacciNumber < 0)
            {
                return Task.FromResult(0L);
            }
            else if (fibonacciNumber == 1)
            {
                return Task.FromResult(1L);
            }
            else
            {
                var result1 = GetFibonacciNumberAsync(fibonacciNumber - 1).Result;
                var result2 = GetFibonacciNumberAsync(fibonacciNumber - 2).Result;

                return Task.FromResult(result1 + result2);
            }
        }
    }
}
