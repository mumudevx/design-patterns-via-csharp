namespace StructuralPatterns.Bridge;

public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementor implementor) : base(implementor)
    {
    }
    
    public override void Operation()
    {
        Console.WriteLine("RefinedAbstraction Operation");
        base.Operation();
    }
}