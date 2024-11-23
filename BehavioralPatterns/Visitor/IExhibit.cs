namespace BehavioralPatterns.Visitor;

public interface IExhibit
{
    public void Accept(IMuseumVisitor museumVisitor);
}