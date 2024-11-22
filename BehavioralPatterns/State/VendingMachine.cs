namespace BehavioralPatterns.State;

public class VendingMachine
{
    private IVendingMachineState _currentState;

    public IVendingMachineState NoCoinState { get; }
    public IVendingMachineState HasCoinState { get; }
    public IVendingMachineState DispensingState { get; }

    public VendingMachine()
    {
        NoCoinState = new NoCoinState(this);
        HasCoinState = new HasCoinState(this);
        DispensingState = new DispensingState(this);

        _currentState = NoCoinState;
    }

    public void SetState(IVendingMachineState state) => _currentState = state;
    public void InsertCoin() => _currentState.InsertCoin();
    public void SelectProduct() => _currentState.SelectProduct();
    public void DispenseProduct() => _currentState.DispenseProduct();
}