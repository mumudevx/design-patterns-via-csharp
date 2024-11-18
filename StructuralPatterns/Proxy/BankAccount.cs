namespace StructuralPatterns.Proxy;

public class BankAccount : IBankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited ${amount}, balance is now ${_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew ${amount}, balance is now ${_balance}");
        }
        else
        {
            Console.WriteLine($"Could not withdraw ${amount}, balance is only ${_balance}");
        }
    }

    public decimal GetBalance() => _balance;
}