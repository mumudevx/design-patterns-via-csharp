namespace StructuralPatterns.Flyweight;

public class Character : ICharacter
{
    private readonly char _symbol;
    private readonly string _font;

    public Character(char symbol, string font)
    {
        _symbol = symbol;
        _font = font;
    }
    
    public void Display(int x, int y, string color)
    {
        Console.WriteLine($"Displaying character {_symbol} at position ({x}, {y}) with color {color} using font {_font}.");
    }
}