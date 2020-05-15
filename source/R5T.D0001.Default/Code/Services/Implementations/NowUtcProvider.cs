using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    /// <summary>
    /// Returns the <see cref="DateTime.UtcNow"/> value.
    /// </summary>
    public class NowUtcProvider : INowUtcProvider
    {
        public Task<DateTime> GetNowUtcAsync()
        {
            var nowUtc = DateTime.UtcNow;

            return Task.FromResult(nowUtc);
        }
    }
}
