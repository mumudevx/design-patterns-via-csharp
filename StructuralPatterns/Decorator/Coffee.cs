namespace StructuralPatterns.Decorator;

public class Coffee : Beverage
{
    public override string GetDescription() => "Coffee";
    public override double Cost() => 4.75;
}