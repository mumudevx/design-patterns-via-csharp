namespace BehavioralPatterns.Memento;

// Originator
public class TextEditor
{
    public string Text { get; set; }
    
    public TextMemento Save()
    {
        return new TextMemento(Text);
    }
    
    public void Restore(TextMemento memento)
    {
        Text = memento.Text;
    }
}