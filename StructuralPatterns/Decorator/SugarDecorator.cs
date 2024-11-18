namespace StructuralPatterns.Decorator;

public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(Beverage beverage) : base(beverage)
    {
    }
    
    public override string GetDescription() => $"{base.GetDescription()} + Sugar";
    public override double Cost() => base.Cost() + 0.25;
}