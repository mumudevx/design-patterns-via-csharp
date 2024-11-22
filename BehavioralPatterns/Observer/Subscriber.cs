namespace BehavioralPatterns.Observer;

public class Subscriber(string name) : ISubscriber
{
    public string Name { get; } = name;

    public void Update(string issue)
    {
        Console.WriteLine($"{Name}, received a newsletter: {issue}");
    }
}