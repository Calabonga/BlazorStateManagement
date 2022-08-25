namespace Calabonga.BlazorStateInMvvm.ViewModels
{
    public interface ICounterModel
    {
        int Count { get; }

        Task Initialize();

        event Action? CounterChanged;

        void IncrementCounter();
    }

    public class CounterModel : ICounterModel
    {
        public int Count { get; private set; }

        public Task Initialize()
        {
            if (Count == 0)
            {
                Count = 1000;
            }

            NotifyCounterChanged();

            return Task.CompletedTask;
        }

        private void NotifyCounterChanged()
        {
            CounterChanged?.Invoke();
        }

        public event Action? CounterChanged;

        public void IncrementCounter()
        {
            Count++;
            NotifyCounterChanged();
        }
    }
}
