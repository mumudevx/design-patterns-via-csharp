namespace BehavioralPatterns.State;

public class HasCoinState(VendingMachine vendingMachine) : IVendingMachineState
{
    public void InsertCoin() => Console.WriteLine("You had already put a coin, please select a product.");

    public void SelectProduct()
    {
        Console.WriteLine("Product has selected. Product is being delivered...");
        vendingMachine.SetState(vendingMachine.DispensingState);
    }

    public void DispenseProduct() => Console.WriteLine("You should select a product.");
}