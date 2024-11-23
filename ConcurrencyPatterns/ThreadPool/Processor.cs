namespace ConcurrencyPatterns.ThreadPool;

public static class Processor
{
    public static void ProcessOrder(object? orderNumber)
    {
        Console.WriteLine($"Order {orderNumber} is being processed by Thread {Environment.CurrentManagedThreadId}");
        Thread.Sleep(2000); // Simulate order processing time
        Console.WriteLine($"Order {orderNumber} has been completed by Thread {Environment.CurrentManagedThreadId}");
    }
}