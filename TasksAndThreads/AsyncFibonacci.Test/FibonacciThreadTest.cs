using AsyncFibonacci.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFibonacci.Test
{
    public class FibonacciThreadTest
    {
        [Fact]
        public void CheckF00()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CheckF01()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(1);
            Assert.Equal(1, result);
        }


        [Fact]
        public void CheckF02()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CheckF03()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CheckF05()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void CheckF10()
        {
            var result = FibonacciThread.GetFibonacciNumberThread(10);
            Assert.Equal(55, result);
        }
    }
}
