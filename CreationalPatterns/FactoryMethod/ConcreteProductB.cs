namespace CreationalPatterns.FactoryMethod;

public class ConcreteProductB : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("ConcreteProductB is doing something.");
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}