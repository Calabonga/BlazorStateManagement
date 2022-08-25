using Microsoft.AspNetCore.Components;

namespace Calabonga.BlazorStateInStateMachine.Services
{
    public class StateService
    {
        public int Count { get; private set; }

        public event Action<ComponentBase, int>? CounterChanged;

        public int IncrementCounter(ComponentBase sender)
        {
            Count++;
            NotifyCounterChanged(sender, Count);
            return Count;
        }

        private void NotifyCounterChanged(ComponentBase sender, int count)
        {
            CounterChanged?.Invoke(sender, count);
        }
    }
}
