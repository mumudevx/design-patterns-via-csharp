namespace BehavioralPatterns.Mediator;

public class AirTrafficControl : IAirTrafficControl
{
    private readonly List<Aircraft> _airCrafts = [];

    public void SendMessage(string message, Aircraft aircraft)
    {
        foreach (var a in _airCrafts.Where(a => a != aircraft))
            a.ReceiveMessage(message);
    }

    public void RegisterAircraftUnderGuidance(Aircraft aircraft)
    {
        if (!_airCrafts.Contains(aircraft))
            _airCrafts.Add(aircraft);
    }
}