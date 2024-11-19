namespace BehavioralPatterns.ChainOfResposibility;

public class ManagerSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Manager")
        {
            Console.WriteLine("ManagerSupportHandler is handling the request");
        }
        else
        {
            NextHandler.HandleRequest(request);
        }
    }
}