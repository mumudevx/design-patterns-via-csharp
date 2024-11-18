namespace StructuralPatterns.Decorator;

public abstract class BeverageDecorator(Beverage beverage) : Beverage
{
    public override string GetDescription() => beverage.GetDescription();
    public override double Cost() => beverage.Cost();
}