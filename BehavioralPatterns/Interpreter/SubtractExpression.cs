namespace BehavioralPatterns.Interpreter;

public class SubtractExpression(IExpression leftExpression, IExpression rightExpression) : IExpression
{
    public int Interpret() => leftExpression.Interpret() - rightExpression.Interpret();
}