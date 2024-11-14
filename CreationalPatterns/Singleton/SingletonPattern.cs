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

// Singleton pattern is a creational pattern that ensures a class has only one instance and provides a global point of access to it.
// It is useful when you need to control the number of instances that can be created, or when you want to provide a single point of access to a resource.
// The pattern is implemented by creating a class with a private constructor and a static method that returns an instance of the class.
// The static method checks if an instance of the class already exists, and if not, creates a new instance.
// The instance is stored in a private static field, which is accessed by the static method.
// The class is responsible for managing the lifetime of the instance, and ensuring that only one instance is created.
// The Singleton pattern is commonly used in scenarios where you need to ensure that only one instance of a class is created