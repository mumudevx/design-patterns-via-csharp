namespace BehavioralPatterns.Visitor;

public class Sculpture : IExhibit
{
    public required string Material { get; set; }
    public required double Height { get; set; }

    public void Accept(IMuseumVisitor museumVisitor) => museumVisitor.Visit(this);
}