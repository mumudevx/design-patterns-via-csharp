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