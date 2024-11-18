namespace StructuralPatterns.Facade;

public class DvdPlayer
{
    public void TurnOn() => Console.WriteLine("The DVD player is on.");
    public void TurnOff() => Console.WriteLine("The DVD player is off.");
    public void Play(string movie) => Console.WriteLine($"Playing {movie}.");
}