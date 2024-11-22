namespace BehavioralPatterns.Observer;

public interface ISubscriber
{
    public string Name { get; }
    
    public void Update(string issue);
}