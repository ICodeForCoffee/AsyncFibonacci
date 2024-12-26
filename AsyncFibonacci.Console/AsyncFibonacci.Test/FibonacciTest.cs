using AsyncFibonacci.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Test
{
    public class FibonacciTest
    {
        [Fact]
        public void CheckF0()
        {
            var result = Fibonacci.GetFibonacciNumber(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CheckF1()
        {
            var result = Fibonacci.GetFibonacciNumber(1);
            Assert.Equal(1, result);
        }


        [Fact]
        public void CheckF2()
        {
            var result = Fibonacci.GetFibonacciNumber(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CheckF3()
        {
            var result = Fibonacci.GetFibonacciNumber(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CheckF5()
        {
            var result = Fibonacci.GetFibonacciNumber(5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void CheckF10()
        {
            var result = Fibonacci.GetFibonacciNumber(10);
            Assert.Equal(55, result);
        }
    }
}
