using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0001.Default
{[ServiceImplementationMarker]
    public class StaticValueNowUtcProvider : INowUtcProvider,IServiceImplementation
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
