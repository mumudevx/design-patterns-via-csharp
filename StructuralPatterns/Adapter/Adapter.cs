namespace StructuralPatterns.Adapter;

// Primary constructor
public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request()
    {
        adaptee.SpecificRequest();
    }
}