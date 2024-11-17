namespace CreationalPatterns.FactoryMethod;

public class ProductB : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("ConcreteProductB is doing something.");
    }
}

public class CreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ProductB();
    }
}