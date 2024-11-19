namespace BehavioralPatterns.Mediator;

public interface IAirTrafficControl
{
    void SendMessage(string message, Aircraft aircraft);
    void RegisterAircraftUnderGuidance(Aircraft aircraft);
}