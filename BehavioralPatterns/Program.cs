#region Chain Of Responsibility

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

Console.WriteLine("Sending unknown request");
basicSupportHandler.HandleRequest("Unknown");

#endregion

