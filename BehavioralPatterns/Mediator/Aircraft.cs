namespace BehavioralPatterns.Mediator;

public abstract class Aircraft
{
    protected IAirTrafficControl _airTrafficControl;

    protected Aircraft(IAirTrafficControl airTrafficControl)
    {
        _airTrafficControl = airTrafficControl;
    }

    public abstract void SendMessage(string message);
    public abstract void ReceiveMessage(string message);
}