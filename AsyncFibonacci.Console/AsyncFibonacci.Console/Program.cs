// See https://aka.ms/new-console-template for more information
using AsyncFibonacci.Console;

Console.WriteLine("Hello, World!");

for (int i = 0; i < 3; i++)
{
    var watch1 = System.Diagnostics.Stopwatch.StartNew();
    var value1 = await FibonacciAsync.GetFibonacciNumberAsync(40);
    watch1.Stop();
    var elapsedMs1 = watch1.ElapsedMilliseconds;


    var watch2 = System.Diagnostics.Stopwatch.StartNew();
    var value2 = FibonacciNoAsync.GetFibonacciNumber(40);
    watch2.Stop();
    var elapsedMs2 = watch2.ElapsedMilliseconds;

    Console.WriteLine($"Async took {elapsedMs1}");
    Console.WriteLine($"Regular took {elapsedMs2}");
}