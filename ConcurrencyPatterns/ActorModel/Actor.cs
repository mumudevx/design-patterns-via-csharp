namespace ConcurrencyPatterns.ActorModel;

public class Actor
{
    private readonly BlockingCollection<Action> _messageQueue = new();

    protected Actor()
    {
        Task.Run(() =>
        {
            foreach (var message in _messageQueue.GetConsumingEnumerable())
            {
                message();
            }
        });
    }

    protected void Send(Action message)
    {
        _messageQueue.Add(message);
    }
}