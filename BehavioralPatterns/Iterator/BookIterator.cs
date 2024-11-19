namespace BehavioralPatterns.Iterator;

public class BookIterator : IIterator<Book>
{
    private readonly List<Book> _books;
    private int _position;

    public BookIterator(List<Book> books)
    {
        _books = books;
        _position = 0;
    }

    public bool HasNext() => _position < _books.Count;

    public Book Next()
    {
        var book = _books[_position];
        _position++;
        return book;
    }
}