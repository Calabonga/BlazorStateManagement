using Fluxor;

namespace Calabonga.BlazorStateWithRedux.StateManagement;

public static class CounterStateReducer
{
    [ReducerMethod]
    public static CounterState Reduce(CounterState state, IncrementCounter action) =>
        new() { Count = state.Count + action.Step };
}