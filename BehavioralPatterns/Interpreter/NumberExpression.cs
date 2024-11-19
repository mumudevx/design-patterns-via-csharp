namespace BehavioralPatterns.Interpreter;

public class NumberExpression(int number) : IExpression
{
    public int Interpret() => number;
}