namespace BehavioralPatterns.Visitor;

public class Fossil : IExhibit
{
    public required string Type { get; set; }
    public required int Age { get; set; }

    public void Accept(IMuseumVisitor museumVisitor) => museumVisitor.Visit(this);
}