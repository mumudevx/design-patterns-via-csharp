#region Chain Of Responsibility

using BehavioralPatterns.Mediator;

Console.WriteLine("Chain Of Responsibility Pattern");

SupportHandler basicSupportHandler = new BasicSupportHandler();
SupportHandler advancedSupportHandler = new AdvancedSupportHandler();
SupportHandler managerSupportHandler = new ManagerSupportHandler();

basicSupportHandler.SetNextHandler(advancedSupportHandler);
advancedSupportHandler.SetNextHandler(managerSupportHandler);

Console.WriteLine("Sending basic request");
basicSupportHandler.HandleRequest("Basic");

Console.WriteLine("Sending advanced request");
basicSupportHandler.HandleRequest("Advanced");

Console.WriteLine("Sending manager request");
basicSupportHandler.HandleRequest("Manager");

// Next line will throw an exception because there is no handler for the unknown request
// Console.WriteLine("Sending unknown request");
// basicSupportHandler.HandleRequest("Unknown");

Console.WriteLine(Environment.NewLine);

#endregion

#region Command Pattern

Console.WriteLine("Command Pattern");

var livingRoomLight = new Light();

ICommand lightOnCommand = new LightOnCommand(livingRoomLight);
ICommand lightOffCommand = new LightOffCommand(livingRoomLight);

var remoteController = new RemoteController();

remoteController.SetCommand(lightOnCommand);
remoteController.PressButton();
remoteController.PressUndoButton();

remoteController.SetCommand(lightOffCommand);
remoteController.PressButton();
remoteController.PressUndoButton();

Console.WriteLine(Environment.NewLine);

#endregion

#region Interpreter Pattern

Console.WriteLine("Interpreter Pattern");

IExpression firstNumber = new NumberExpression(33);
IExpression secondNumber = new NumberExpression(11);

var addExpression = new AddExpression(firstNumber, secondNumber);
var subtractExpression = new SubtractExpression(firstNumber, secondNumber);

Console.WriteLine($"Add expression: {addExpression.Interpret()}");
Console.WriteLine($"Subtract expression: {subtractExpression.Interpret()}");

Console.WriteLine(Environment.NewLine);

#endregion

#region Iterator Pattern

Console.WriteLine("Iterator Pattern");

var bookCollection = new BookCollection();
bookCollection.AddBook(new Book { Title = "Book 1" });
bookCollection.AddBook(new Book { Title = "Book 2" });
bookCollection.AddBook(new Book { Title = "Book 3" });

var bookIterator = bookCollection.CreateIterator();

while (bookIterator.HasNext())
{
    var book = bookIterator.Next();
    Console.WriteLine($"Book title: {book.Title}");
}

Console.WriteLine(Environment.NewLine);

#endregion

#region Mediator Pattern

Console.WriteLine("Mediator Pattern");

var airTrafficControl = new AirTrafficControl();

Aircraft boeing737 = new Boeing737(airTrafficControl);
Aircraft airbusA320 = new AirbusA320(airTrafficControl);

airTrafficControl.RegisterAircraftUnderGuidance(boeing737);
airTrafficControl.RegisterAircraftUnderGuidance(airbusA320);

boeing737.SendMessage("This is Boeing737 requesting takeoff clearance");
airbusA320.SendMessage("This is AirbusA320 requesting landing clearance");

Console.WriteLine(Environment.NewLine);

#endregion