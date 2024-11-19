namespace BehavioralPatterns.ChainOfResposibility;

public class BasicSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if(request == "Basic")
        {
            Console.WriteLine("BasicSupportHandler is handling the request");
        }
        else
        {
            NextHandler.HandleRequest(request);
        }
    }
}