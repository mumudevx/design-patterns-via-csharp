namespace ConcurrencyPatterns.ActorModel;

public class PaymentActor : Actor
{
    public void ProcessPayment(string orderDetails)
    {
        Send(() =>
        {
            Console.WriteLine($"Processing payment for: {orderDetails}");
            Task.Delay(1000).Wait(); // Simulate payment
            Console.WriteLine($"Payment for {orderDetails} completed.");
        });
    }
}