namespace BehavioralPatterns.Visitor;

public class Painting : IExhibit
{
    public required string Artist { get; set; }
    public required int Year { get; set; }
    
    public void Accept(IMuseumVisitor museumVisitor) => museumVisitor.Visit(this);
}