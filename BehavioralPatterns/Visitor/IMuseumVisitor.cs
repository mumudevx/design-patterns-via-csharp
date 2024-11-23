namespace BehavioralPatterns.Visitor;

public interface IMuseumVisitor
{
    public void Visit(Painting painting);
    public void Visit(Sculpture sculpture);
    public void Visit(Fossil fossil);
}