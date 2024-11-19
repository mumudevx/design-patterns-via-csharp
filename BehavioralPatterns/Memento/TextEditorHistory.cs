namespace BehavioralPatterns.Memento;

// Caretaker
public class TextEditorHistory
{
    private readonly Stack<TextMemento> _history = new();

    public void Save(TextEditor editor)
    {
        _history.Push(editor.Save());
    }

    public void Undo(TextEditor editor)
    {
        if (_history.Count == 0)
            return;

        var memento = _history.Pop();
        editor.Restore(memento);
    }
}