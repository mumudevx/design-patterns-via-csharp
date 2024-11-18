namespace StructuralPatterns.Facade;

public class SoundSystem
{
    public void TurnOn() => Console.WriteLine("The sound system is on.");
    public void TurnOff() => Console.WriteLine("The sound system is off.");
    public void SetVolume(int volume) => Console.WriteLine($"The volume is set to {volume}.");
}