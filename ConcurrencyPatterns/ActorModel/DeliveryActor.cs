namespace ConcurrencyPatterns.ActorModel;

public class DeliveryActor : Actor
{
    public void ScheduleDelivery(string orderDetails)
    {
        Send(() =>
        {
            Console.WriteLine($"Scheduling delivery for: {orderDetails}");
            Task.Delay(1000).Wait(); // Simulate delivery
            Console.WriteLine($"Delivery for {orderDetails} scheduled.");
        });
    }
}