namespace BehavioralPatterns.Observer;

public class Newsletter(string name)
{
    public string Name { get; } = name;

    private readonly List<ISubscriber> _subscribers = [];

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
        Console.WriteLine($"{subscriber.Name}, subscribed to '{Name}' newsletter.");
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
        Console.WriteLine($"{subscriber.Name}, unsubscribed from '{Name}' newsletter.");
    }

    public void Publish(string issue)
    {
        Console.WriteLine($"\n{Name} newsletter was published: {issue}");
        Notify(issue);
    }

    private void Notify(string issue)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(issue);
        }
    }
}