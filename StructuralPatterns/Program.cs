// Call design patterns at runtime

#region Adapter Pattern

Console.WriteLine("Adapter Pattern");

var adaptee = new Adaptee();
var target = new Adapter(adaptee);

target.Request();

Console.WriteLine(Environment.NewLine);

#endregion

#region Bridge Pattern

Console.WriteLine("Bridge Pattern");

IImplementor implementorA = new ImplementorA();
Abstraction abstractionA = new RefinedAbstraction(implementorA);
abstractionA.Operation();

IImplementor implementorB = new ImplementorB();
Abstraction abstractionB = new RefinedAbstraction(implementorB);
abstractionB.Operation();

Console.WriteLine(Environment.NewLine);

#endregion

return;