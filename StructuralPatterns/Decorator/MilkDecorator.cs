namespace StructuralPatterns.Decorator;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage) : base(beverage)
    {
    }
    
    public override string GetDescription() => $"{base.GetDescription()} + Milk";
    public override double Cost() => base.Cost() + 0.5;
}