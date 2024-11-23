namespace BehavioralPatterns.TemplateMethod;

public abstract class OrderProcessTemplate
{
    public void ProcessOrder()
    {
        SelectItem();
        PlaceOrder();

        if (IsDeliveryRequired())
            DeliverItem();
    }

    protected virtual bool IsDeliveryRequired() => true;
    protected abstract void SelectItem();
    protected abstract void PlaceOrder();
    protected virtual void DeliverItem() => Console.WriteLine("Delivering the item to the customer.");
}