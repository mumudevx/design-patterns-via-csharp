namespace BehavioralPatterns.Command;

// Invoker
public class RemoteController
{
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;
    public void PressButton() => _command.Execute();
    public void PressUndoButton() => _command.Undo();
}