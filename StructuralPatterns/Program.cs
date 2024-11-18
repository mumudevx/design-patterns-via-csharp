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

#region Composite Pattern

Console.WriteLine("Composite Pattern");

Component rootFolder = new Composite("rootFolder");
rootFolder.Add(new Leaf("file1.txt"));
rootFolder.Add(new Leaf("file2.txt"));

Component subFolder = new Composite("subfolder");
subFolder.Add(new Leaf("file3.txt"));
subFolder.Add(new Leaf("file4.jpg"));

rootFolder.Add(subFolder);
rootFolder.Add(new Leaf("file5.pdf"));

var secondSubFolder = new Leaf("secondSubFolder");
rootFolder.Add(secondSubFolder);
rootFolder.Remove(secondSubFolder);

rootFolder.Display(1);

Console.WriteLine(Environment.NewLine);

#endregion

return;