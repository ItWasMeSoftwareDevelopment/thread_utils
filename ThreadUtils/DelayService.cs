using System;
using System.Threading;
using System.Threading.Tasks;

namespace ItWasMe.ThreadUtils
{
    public interface IDelayService
    {
        void ThreadSleep(TimeSpan sleep);
        void ThreadSleep(int ms);
        Task DelayAsync(TimeSpan sleep);
        Task DelayAsync(int ms);
        Task DelayAsync(TimeSpan sleep, CancellationToken token);
        Task DelayAsync(int ms, CancellationToken token);
    }

    public class DelayService : IDelayService
    {
        public void ThreadSleep(TimeSpan sleep)
        {
            Thread.Sleep(sleep);
        }
        public void ThreadSleep(int ms)
        {
            Thread.Sleep(ms);
        }

        public async Task DelayAsync(TimeSpan sleep)
        {
            await Task.Delay(sleep);
        }

        public async Task DelayAsync(int ms)
        {
            await Task.Delay(ms);
        }

        public async Task DelayAsync(TimeSpan sleep, CancellationToken token)
        {
            await Task.Delay(sleep, token);
        }

        public async Task DelayAsync(int ms, CancellationToken token)
        {
            await Task.Delay(ms, token);
        }
    }
}
