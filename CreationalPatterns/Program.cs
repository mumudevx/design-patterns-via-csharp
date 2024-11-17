// Calls design patterns at runtime

#region Singleton Pattern

using CreationalPatterns.Builder;

Console.WriteLine("Singleton Pattern");

var singleton1 = SingletonPattern.Instance;
singleton1.DoSomething();

Console.WriteLine(Environment.NewLine);

#endregion

#region Factory Method Pattern

Console.WriteLine("Factory Method Pattern");

Creator creatorA = new CreatorA();
BuildProduct(creatorA);

Creator creatorB = new CreatorB();
BuildProduct(creatorB);

Console.Write(Environment.NewLine);

#endregion

#region Abstract Factory Pattern

Console.WriteLine("Abstract Factory Pattern");

ClientMethod(new Factory1());
ClientMethod(new Factory2());

Console.Write(Environment.NewLine);

#endregion

#region Builder Pattern

Console.WriteLine("Builder Pattern");

var director = new Director();
var builder = new Builder();

director.Construct(builder);
var product = builder.GetProduct();
product.ShowParts();

Console.Write(Environment.NewLine);

#endregion

#region Prototype Pattern

Console.WriteLine("Prototype Pattern");



Console.WriteLine(Environment.NewLine);

#endregion

return;

// Method to build product (Factory Method Pattern)
void BuildProduct(Creator creator) => creator.FactoryMethod().DoSomething();

// Client method to create product (Abstract Factory Method Pattern)
void ClientMethod(IFactory factory)
{
    var productA = factory.CreateProductA();
    productA.BuyMe();

    var productB = factory.CreateProductB();
    productB.BuyMe();
}