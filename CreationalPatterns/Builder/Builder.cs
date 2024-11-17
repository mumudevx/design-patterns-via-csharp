namespace CreationalPatterns.Builder;

public class Builder : IBuilder
{
    private readonly Product _product = new();
    
    public void BuildPartA() => _product.Add("Part A");
    public void BuildPartB() => _product.Add("Part B");
    public void BuildPartC() => _product.Add("Part C");
    
    public Product GetProduct() => _product;
}