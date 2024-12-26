using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Console
{
    public class FibonacciAwait
    {
        public static async Task<long> GetFibonacciNumberAwait(long fibonacciNumber)
        {
            if (fibonacciNumber < 0)
            {
                //var item = await Task.FromResult(0);
                return 0;
            }
            else if (fibonacciNumber == 1)
            {
                return 1;
            }
            else
            {
                var result1 = await GetFibonacciNumberAwait(fibonacciNumber - 1);
                var result2 = await GetFibonacciNumberAwait(fibonacciNumber - 2);

                return result1 + result2;
            }
        }
        
    }
}
