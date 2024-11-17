namespace CreationalPatterns.Prototype;

public class PrototypeA : IPrototype
{
    public string Name { get; set; }
    
    public IPrototype Clone()
    {
        return (IPrototype)MemberwiseClone();
    }
    
    public void PrintName()
    {
        Console.WriteLine($"Name: {Name}");
    }
}