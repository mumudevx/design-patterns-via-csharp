namespace BehavioralPatterns.Visitor;

public class MuseumGuide : IMuseumVisitor
{
    public void Visit(Painting painting) =>
        Console.WriteLine($"This painting made by {painting.Artist} at year {painting.Year}.");

    public void Visit(Sculpture sculpture) =>
        Console.WriteLine(
            $"This sculpture's height is {sculpture.Height} meters and made by {sculpture.Material} material.");

    public void Visit(Fossil fossil) =>
        Console.WriteLine($"This fossil of {fossil.Type} and {fossil.Age} million years old.");
}