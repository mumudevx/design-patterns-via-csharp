namespace CreationalPatterns.FactoryMethod;

public class ConcreteProductA : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("ConcreteProductA is doing something.");
    }
}

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}