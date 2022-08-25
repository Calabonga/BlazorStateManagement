using Fluxor;

namespace Calabonga.BlazorStateWithRedux.StateManagement;

public class CounterStateFeature : Feature<CounterState>
{
    public override string GetName() => nameof(CounterState);

    protected override CounterState GetInitialState()
    {
        return new CounterState();
    }
}