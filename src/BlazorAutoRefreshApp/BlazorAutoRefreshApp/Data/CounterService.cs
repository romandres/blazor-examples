namespace BlazorAutoRefreshApp.Data
{
    public class CounterService
    {
        private int currentCount;

        /// <summary>
        /// This event is fired whenever the count value changes.
        /// The current value of Count is passed as an event argument.
        /// </summary>
        public event EventHandler<int>? CountChanged;

        /// <summary>
        /// Gets the current count value.
        /// </summary>
        public int Count { get => currentCount; }

        /// <summary>
        /// Increases the current count value by 1.
        /// </summary>
        public void CountUp() => ChangeCount(1);

        /// <summary>
        /// Decreases the current count value by 1.
        /// </summary>
        public void CountDown() => ChangeCount(-1);

        private void ChangeCount(int addValue)
        {
            // Update the count's current value.
            currentCount += addValue;
            // Fire the CountChanged event to notifiy event subscribers about the change to the count's value.
            CountChanged?.Invoke(this, currentCount);
        }
    }
}
