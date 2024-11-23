namespace BehavioralPatterns.Strategy;

public class CryptoPayment : IPaymentStrategy
{
    public void Pay(decimal amount) => Console.WriteLine($"Crypto payment of ${amount} completed.");
}