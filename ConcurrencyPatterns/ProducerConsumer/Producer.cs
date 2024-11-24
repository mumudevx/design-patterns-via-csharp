namespace ConcurrencyPatterns.ProducerConsumer;

public class Producer(BlockingCollection<string> ordersQueue, string name)
{
    private string Name { get; } = name;

    public void Produce()
    {
        for (var i = 0; i < 7; i++)
        {
            var order = $"Order {i + 1} by {Name}";
            Console.WriteLine($"{Name} placed: {order}");
            ordersQueue.Add(order);
            Thread.Sleep(new Random().Next(500, 1500)); // Simulate time to taking order
        }
    }
}