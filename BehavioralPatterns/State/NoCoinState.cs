namespace BehavioralPatterns.State;

public class NoCoinState(VendingMachine vendingMachine) : IVendingMachineState
{
    public void InsertCoin()
    {
        Console.WriteLine("Coin inserted. You can choose the product.");
        vendingMachine.SetState(vendingMachine.HasCoinState);
    }

    public void SelectProduct() => Console.WriteLine("You should put coin.");

    public void DispenseProduct() => Console.WriteLine("Insert a coin then select a product");
}