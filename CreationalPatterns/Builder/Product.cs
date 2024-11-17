namespace CreationalPatterns.Builder;

public class Product
{
    private readonly List<string> _parts = [];
    
    public void Add(string part)
    {
        _parts.Add(part);
    }
    
    public void ShowParts()
    {
        Console.WriteLine("\nProduct Parts -------");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}