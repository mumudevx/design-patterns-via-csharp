namespace BehavioralPatterns.Strategy;

public class PaypalPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Paypal payment of ${amount} completed.");
}