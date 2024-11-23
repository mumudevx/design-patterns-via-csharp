#region Thread Pool Pattern

Console.WriteLine("Thread Pool Pattern");

// Queue to simulate incoming orders
var orderQueue = new ConcurrentQueue<int>();
for (var i = 1; i <= 10; i++)
{
    orderQueue.Enqueue(i);
}

// Using ThreadPool to process orders
while (orderQueue.TryDequeue(out var orderNumber))
    ThreadPool.QueueUserWorkItem(Processor.ProcessOrder, orderNumber);

Console.WriteLine("All orders have been queued for processing.");
Console.ReadLine(); // Keep the console open to see thread outputs

Console.WriteLine(Environment.NewLine);

#endregion