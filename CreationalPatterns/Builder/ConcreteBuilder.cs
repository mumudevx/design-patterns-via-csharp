namespace CreationalPatterns.Builder;

public class ConcreteBuilder : IBuilder
{
    private readonly ConcreteProduct _product = new();
    
    public void BuildPartA() => _product.Add("Part A");
    public void BuildPartB() => _product.Add("Part B");
    public void BuildPartC() => _product.Add("Part C");
    
    public ConcreteProduct GetProduct() => _product;
}