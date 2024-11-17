namespace CreationalPatterns.AbstractFactory;

public interface IFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}