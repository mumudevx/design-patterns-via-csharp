namespace CreationalPatterns.AbstractFactory;

public class ConcreteProductA1 : IProductA
{
    public void BuyMe()
    {
        Console.WriteLine("Buy ConcreteProductA1");
    }
}

public class ConcreteProductA2 : IProductA
{
    public void BuyMe()
    {
        Console.WriteLine("Buy ConcreteProductA2");
    }
}