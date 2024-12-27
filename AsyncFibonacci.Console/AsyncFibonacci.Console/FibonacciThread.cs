using System;
using System.Threading;

namespace AsyncFibonacci.Console
{
    public class FibonacciThread
    {
        public static long GetFibonacciNumberThread(long fibonacciNumber)
        {
            FibonacciThreadWorker worker = new FibonacciThreadWorker(fibonacciNumber);

            Thread instance1 = new Thread(new ThreadStart(worker.GetFibonacciNumberThread));
            instance1.Start();
            instance1.Join();

            return worker.result;
        }
    }

    public class FibonacciThreadWorker
    {
        private long _fibonacciNumber;
        public long result;

        public FibonacciThreadWorker(long fibonacciNumber)
        {
            _fibonacciNumber = fibonacciNumber;
        }

        public void GetFibonacciNumberThread()
        {
            if (_fibonacciNumber < 0)
            {
                result = 0;
            }
            else if (_fibonacciNumber == 1)
            {
                result = 1;
            }
            else
            {
                FibonacciThreadWorker worker1 = new FibonacciThreadWorker(_fibonacciNumber - 1);
                FibonacciThreadWorker worker2 = new FibonacciThreadWorker(_fibonacciNumber - 2);

                Thread instance1 = new Thread(new ThreadStart(worker1.GetFibonacciNumberThread));
                Thread instance2 = new Thread(new ThreadStart(worker2.GetFibonacciNumberThread));
                instance1.Start();
                instance2.Start();
                instance1.Join();
                instance2.Join();

                result = worker1.result + worker2.result;
            }
        }
    }
}

