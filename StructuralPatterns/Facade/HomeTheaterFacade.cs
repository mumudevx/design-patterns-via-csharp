namespace StructuralPatterns.Facade;

public class HomeTheaterFacade
{
    private readonly Television _television;
    private readonly SoundSystem _soundSystem;
    private readonly DvdPlayer _dvdPlayer;
    
    public HomeTheaterFacade(Television television, SoundSystem soundSystem, DvdPlayer dvdPlayer)
    {
        _television = television;
        _soundSystem = soundSystem;
        _dvdPlayer = dvdPlayer;
    }
    
    public void StartMovie(string movie)
    {
        _television.TurnOn();
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(25);
        _dvdPlayer.TurnOn();
        _dvdPlayer.Play(movie);
    }
    
    public void StopMovie()
    {
        _dvdPlayer.TurnOff();
        _soundSystem.TurnOff();
        _television.TurnOff();
    }
}