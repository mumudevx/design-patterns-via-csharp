namespace ConcurrencyPatterns.AsyncAwait;

public class TodoItem
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = null!;
    public bool Completed { get; set; }
}