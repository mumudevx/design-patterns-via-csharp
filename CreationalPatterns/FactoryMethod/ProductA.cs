namespace CreationalPatterns.FactoryMethod;

public class ProductA : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("ConcreteProductA is doing something.");
    }
}

public class CreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ProductA();
    }
}