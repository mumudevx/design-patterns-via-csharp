namespace BehavioralPatterns.Interpreter;

public class AddExpression(IExpression leftExpression, IExpression rightExpression) : IExpression
{
    public int Interpret() => leftExpression.Interpret() + rightExpression.Interpret();
}