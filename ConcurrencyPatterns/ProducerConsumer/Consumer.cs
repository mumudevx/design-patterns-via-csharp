namespace ConcurrencyPatterns.ProducerConsumer;

public class Consumer(BlockingCollection<string> ordersQueue, string name)
{
    private string Name { get; } = name;

    public void Consume()
    {
        foreach (var order in ordersQueue.GetConsumingEnumerable())
        {
            Console.WriteLine($"{Name} is preparing: {order}");
            Thread.Sleep(new Random().Next(1000, 2000)); // Simulate time to prepare the order
        }
    }
}