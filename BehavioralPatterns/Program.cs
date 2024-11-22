#region Chain Of Responsibility

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

#region Memento Pattern

Console.WriteLine("Memento Pattern");

var textEditor = new TextEditor();
var textEditorHistory = new TextEditorHistory();

textEditor.Text = "Hello, World! This is my first version.";
textEditorHistory.Save(textEditor);

textEditor.Text = "Hello, Jupyter! Also this is my second version.";
textEditorHistory.Save(textEditor);

textEditor.Text = "This is my third version.";

Console.WriteLine($"Current text: {textEditor.Text}");

textEditorHistory.Undo(textEditor);
Console.WriteLine($"After undo: {textEditor.Text}");

textEditorHistory.Undo(textEditor);
Console.WriteLine($"After undo: {textEditor.Text}");

Console.WriteLine(Environment.NewLine);

#endregion

#region Observer Pattern

Console.WriteLine("Observer Pattern");

var financeNewsletter = new Newsletter("Financial Freedom");

var personOne = new Subscriber("Jose Muro");
var personTwo = new Subscriber("Guillermina Walker");

financeNewsletter.Subscribe(personOne);
financeNewsletter.Subscribe(personTwo);

financeNewsletter.Publish("Daily Habits of People Who Achieve Financial Freedom");

financeNewsletter.Unsubscribe(personOne);

financeNewsletter.Publish("Passive Income 101");

Console.WriteLine(Environment.NewLine);

#endregion

#region State Pattern

Console.WriteLine("State Pattern");

var vendingMachine = new VendingMachine();

vendingMachine.SelectProduct(); // You should put coin.
vendingMachine.InsertCoin(); // Coin inserted. You can choose the product.
vendingMachine.InsertCoin(); // You had already put a coin, please select a product.
vendingMachine.SelectProduct(); // Product has selected. Product is being delivered...
vendingMachine.DispenseProduct(); // The product has been delivered.

Console.WriteLine(Environment.NewLine);

#endregion