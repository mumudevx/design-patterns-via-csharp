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

#region Decorator Pattern

Console.WriteLine("Decorator Pattern");

Beverage coffee = new Coffee();
Console.WriteLine($"{coffee.GetDescription()} ${coffee.Cost()}");

coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} ${coffee.Cost()}");

coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} ${coffee.Cost()}");

Console.WriteLine(Environment.NewLine);

#endregion

#region Facade Pattern

Console.WriteLine("Facade Pattern");

var television = new Television();
var soundSystem = new SoundSystem();
var dvdPlayer = new DvdPlayer();

var homeTheaterFacade = new HomeTheaterFacade(television, soundSystem, dvdPlayer);

homeTheaterFacade.StartMovie("The Matrix");
homeTheaterFacade.StopMovie();

Console.WriteLine(Environment.NewLine);

#endregion

#region Flyweight Pattern

Console.WriteLine("Flyweight Pattern");

var characterFactory = new CharacterFactory();

var characterA = characterFactory.GetCharacter('A', "Roboto");
characterA.Display(12, 34, "Red");

var characterB = characterFactory.GetCharacter('B', "Roboto");
characterB.Display(56, 78, "Blue");

var characterC = characterFactory.GetCharacter('C', "Roboto");
characterC.Display(90, 12, "Green");

Console.WriteLine(Environment.NewLine);

#endregion

#region Proxy Pattern

Console.WriteLine("Proxy Pattern");

var bankAccount = new BankAccountProxy("myUltraSecurePassword");

bankAccount.Deposit(100);
bankAccount.Withdraw(50);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

bankAccount.Withdraw(100);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

Console.WriteLine(Environment.NewLine);

#endregion

