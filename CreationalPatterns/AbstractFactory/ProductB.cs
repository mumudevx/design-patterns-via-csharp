namespace CreationalPatterns.AbstractFactory;

public class ConcreteProductB1 : IProductB
{
    public void BuyMe()
    {
        Console.WriteLine("Buy ConcreteProductB1");
    }
}

public class ConcreteProductB2 : IProductB
{
    public void BuyMe()
    {
        Console.WriteLine("Buy ConcreteProductB2");
    }
}