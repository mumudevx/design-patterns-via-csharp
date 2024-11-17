namespace CreationalPatterns.Builder;

public class ConcreteDirector
{
    public void Construct(IBuilder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}