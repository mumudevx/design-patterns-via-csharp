namespace BehavioralPatterns.State;

public class DispensingState(VendingMachine vendingMachine) : IVendingMachineState
{
    public void InsertCoin() => Console.WriteLine("The product is currently being delivered. Please wait.");

    public void SelectProduct() =>
        Console.WriteLine("The product is currently being delivered. You cannot select a new product.");

    public void DispenseProduct()
    {
        Console.WriteLine("The product has been delivered.");
        vendingMachine.SetState(vendingMachine.NoCoinState);
    }
}