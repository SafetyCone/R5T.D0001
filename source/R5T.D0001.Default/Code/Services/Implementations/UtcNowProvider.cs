using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    /// <summary>
    /// Returns the <see cref="DateTime.UtcNow"/> value.
    /// </summary>
    public class UtcNowProvider : IUtcNowProvider
    {
        public Task<DateTime> GetUtcNowAsync()
        {
            var utcNow = DateTime.UtcNow;

            return Task.FromResult(utcNow);
        }
    }
}
