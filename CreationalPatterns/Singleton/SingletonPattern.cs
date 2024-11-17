namespace CreationalPatterns.Singleton;

public class SingletonPattern
{
    private static SingletonPattern? _instance;
    private static readonly object Lock = new();

    // Private constructor to prevent instantiation from outside
    private SingletonPattern()
    {
    }

    public static SingletonPattern Instance
    {
        get
        {
            lock (Lock)
            {
                return _instance ??= new SingletonPattern(); // If _instance is null, create a new instance
            }
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is working.");
    }
}