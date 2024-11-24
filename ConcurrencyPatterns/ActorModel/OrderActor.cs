namespace ConcurrencyPatterns.ActorModel;

public class OrderActor : Actor
{
    public void ProcessOrder(string orderDetails)
    {
        Send(() =>
        {
            Console.WriteLine($"Processing order: {orderDetails}");
            Task.Delay(1000).Wait(); // Simulate processing
            Console.WriteLine($"Order {orderDetails} processed.");
        });
    }
}