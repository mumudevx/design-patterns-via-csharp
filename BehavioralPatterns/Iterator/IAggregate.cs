namespace BehavioralPatterns.Iterator;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}