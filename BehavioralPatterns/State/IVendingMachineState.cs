namespace BehavioralPatterns.State;

public interface IVendingMachineState
{
    public void InsertCoin();
    public void SelectProduct();
    public void DispenseProduct();
}