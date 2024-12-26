using AsyncFibonacci.Console;
using System.Security.Cryptography.X509Certificates;

namespace AsyncFibonacci.Test
{
    public class FibonacciAsyncTest
    {
        [Fact]
        public async Task CheckF0()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public async Task CheckF1()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(1);
            Assert.Equal(1, result);
        }


        [Fact]
        public async Task CheckF2()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task CheckF3()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public async Task CheckF5()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(5);
            Assert.Equal(5, result);
        }

        [Fact]
        public async Task CheckF10()
        {
            var result = await FibonacciAsync.GetFibonacciNumberAsync(10);
            Assert.Equal(55, result);
        }
    }
}
