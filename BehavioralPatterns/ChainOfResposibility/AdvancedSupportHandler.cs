namespace BehavioralPatterns.ChainOfResposibility;

public class AdvancedSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if(request == "Advanced")
        {
            Console.WriteLine("AdvancedSupportHandler is handling the request");
        }
        else
        {
            NextHandler.HandleRequest(request);
        }
    }
}