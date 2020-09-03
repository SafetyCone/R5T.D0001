using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class StaticValueNowUtcProvider : INowUtcProvider
    {
        /// <summary>
        /// Note: not thread-safe.
        /// </summary>
        public static DateTime NowUtc { get; set; }


        public Task<DateTime> GetNowUtc()
        {
            return Task.FromResult(StaticValueNowUtcProvider.NowUtc);
        }
    }
}
