using AsyncFibonacci.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Test
{
    public class FibonacciAwaitTest
    {
        [Fact]
        public async Task CheckF0()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public async Task CheckF1()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(1);
            Assert.Equal(1, result);
        }


        [Fact]
        public async Task CheckF2()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task CheckF3()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public async Task CheckF5()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(5);
            Assert.Equal(5, result);
        }

        [Fact]
        public async Task CheckF10()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(10);
            Assert.Equal(55, result);
        }
    }
}
