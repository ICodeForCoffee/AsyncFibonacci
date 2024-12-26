// See https://aka.ms/new-console-template for more information
using AsyncFibonacci.Console;

Console.WriteLine("Async Performance Tester");

ExecuteComparison(20);
ExecuteComparison(30);
ExecuteComparison(35);
ExecuteComparison(40);

async void ExecuteComparison(int fibonacciNumber)
{
    Console.WriteLine($"Calculating the {fibonacciNumber}\n");
    var watch1 = System.Diagnostics.Stopwatch.StartNew();
    var value1 = await FibonacciAsync.GetFibonacciNumberAsync(fibonacciNumber);
    watch1.Stop();
    var elapsedMs1 = watch1.ElapsedMilliseconds;


    var watch2 = System.Diagnostics.Stopwatch.StartNew();
    var value2 = FibonacciNoAsync.GetFibonacciNumber(fibonacciNumber);
    watch2.Stop();
    var elapsedMs2 = watch2.ElapsedMilliseconds;

    Console.WriteLine($"Async took {elapsedMs1} ms");
    Console.WriteLine($"Regular took {elapsedMs2} ms\n");
}