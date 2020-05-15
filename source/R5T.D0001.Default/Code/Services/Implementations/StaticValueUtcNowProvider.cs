using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class StaticValueUtcNowProvider : IUtcNowProvider
    {
        /// <summary>
        /// Note: not thread-safe.
        /// </summary>
        public static DateTime UtcNow { get; set; }


        public Task<DateTime> GetUtcNowAsync()
        {
            return Task.FromResult(StaticValueUtcNowProvider.UtcNow);
        }
    }
}
