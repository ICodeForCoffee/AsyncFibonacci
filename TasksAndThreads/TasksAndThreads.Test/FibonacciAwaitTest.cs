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
        public async Task CheckF00()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public async Task CheckF01()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(1);
            Assert.Equal(1, result);
        }


        [Fact]
        public async Task CheckF02()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task CheckF03()
        {
            var result = await FibonacciAwait.GetFibonacciNumberAwait(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public async Task CheckF05()
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
