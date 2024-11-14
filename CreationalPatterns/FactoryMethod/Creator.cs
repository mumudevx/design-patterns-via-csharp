namespace CreationalPatterns.FactoryMethod;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public void AnOperation()
    {
        var product = FactoryMethod();
        product.DoSomething();
    }
}