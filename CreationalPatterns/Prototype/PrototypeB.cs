namespace CreationalPatterns.Prototype;

public class PrototypeB : IPrototype
{
    public int Value { get; set; }
    
    public IPrototype Clone()
    {
        return (IPrototype)MemberwiseClone();
    }
    
    public void PrintValue()
    {
        Console.WriteLine($"Value: {Value}");
    }
}