namespace BehavioralPatterns.TemplateMethod;

public class StorePickupOrder : OrderProcessTemplate
{
    protected override bool IsDeliveryRequired() => false;
    protected override void SelectItem() => Console.WriteLine("Item selected in the store.");
    protected override void PlaceOrder() => Console.WriteLine("Order placed at the store.");
}