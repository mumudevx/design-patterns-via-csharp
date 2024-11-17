namespace CreationalPatterns.Builder;

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    
    Product GetProduct();
}