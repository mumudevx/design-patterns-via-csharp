namespace BehavioralPatterns.TemplateMethod;

public class OnlineOrder : OrderProcessTemplate
{
    protected override void SelectItem() => Console.WriteLine("Item selected online.");
    protected override void PlaceOrder() => Console.WriteLine("Order placed online with payment.");
    protected override void DeliverItem() => Console.WriteLine("Item delivered to the customer's address.");
}