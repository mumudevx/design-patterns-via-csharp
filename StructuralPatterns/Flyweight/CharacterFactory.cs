namespace StructuralPatterns.Flyweight;

public class CharacterFactory
{
    private readonly Dictionary<char, ICharacter> _characters = new();
    
    public ICharacter GetCharacter(char symbol, string font)
    {
        if (_characters.TryGetValue(symbol, out var value))
            return value;
        
        value = new Character(symbol, font);
        _characters[symbol] = value;

        return value;
    }
}