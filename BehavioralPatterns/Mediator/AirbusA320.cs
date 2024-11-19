namespace BehavioralPatterns.Mediator;

public class AirbusA320 : Aircraft
{
    public AirbusA320(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
    {
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"AirbusA320 sending message: {message}");
        _airTrafficControl.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"AirbusA320 received message: {message}");
    }
}