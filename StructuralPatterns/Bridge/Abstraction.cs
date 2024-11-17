namespace StructuralPatterns.Bridge;

// Primary constructor
public class Abstraction(IImplementor implementor)
{
    public virtual void Operation()
    {
        implementor.Operation();
    }
}