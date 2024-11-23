namespace BehavioralPatterns.Strategy;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Credit card payment of ${amount} completed.");
}