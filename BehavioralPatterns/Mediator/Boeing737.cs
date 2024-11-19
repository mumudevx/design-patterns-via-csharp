namespace BehavioralPatterns.Mediator;

public class Boeing737 : Aircraft
{
    public Boeing737(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
    {
    }
    
    public override void SendMessage(string message)
    {
        Console.WriteLine($"Boeing737 sending message: {message}");
        _airTrafficControl.SendMessage(message, this);
    }
    
    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"Boeing737 received message: {message}");
    }
}