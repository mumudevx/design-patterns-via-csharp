namespace StructuralPatterns.Proxy;

public class BankAccountProxy : IBankAccount
{
    private readonly BankAccount _bankAccount;
    private readonly string _password;

    public BankAccountProxy(string password)
    {
        _bankAccount = new BankAccount();
        _password = password;
    }

    private bool Authenticate(string password)
    {
        return password == _password;
    }

    public void Deposit(decimal amount)
    {
        Console.WriteLine("Enter your password:");
        var passwordFromUser = Console.ReadLine();

        if (passwordFromUser == null)
        {
            Console.WriteLine("Could not deposit, password is invalid");
            return;
        }

        if (Authenticate(passwordFromUser))
        {
            _bankAccount.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Incorrect password, could not deposit");
        }
    }

    public void Withdraw(decimal amount)
    {
        Console.WriteLine("Enter your password:");
        var passwordFromUser = Console.ReadLine();

        if (passwordFromUser == null)
        {
            Console.WriteLine("Could not withdraw, password is invalid");
            return;
        }

        if (Authenticate(passwordFromUser))
        {
            _bankAccount.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Incorrect password, could not withdraw");
        }
    }

    public decimal GetBalance()
    {
        Console.WriteLine("Enter your password:");
        var passwordFromUser = Console.ReadLine();

        if (passwordFromUser == null)
        {
            Console.WriteLine("Could not get balance, password is invalid");
            return 0;
        }

        if (Authenticate(passwordFromUser))
        {
            return _bankAccount.GetBalance();
        }

        Console.WriteLine("Incorrect password, could not get balance");
        return 0;
    }
}