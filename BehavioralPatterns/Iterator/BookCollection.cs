namespace BehavioralPatterns.Iterator;

public class BookCollection : IAggregate<Book>
{
    private readonly List<Book> _books = [];

    public void AddBook(Book book) => _books.Add(book);

    public IIterator<Book> CreateIterator() => new BookIterator(_books);
}